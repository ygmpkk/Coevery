﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Coevery;
using Coevery.ContentManagement;
using Coevery.Core.Navigation.Models;
using Coevery.Core.Navigation.Services;
using Coevery.Core.Navigation.ViewModels;
using Coevery.Core.Title.Models;
using Coevery.Localization;
using Coevery.UI;
using Coevery.UI.Navigation;

namespace Coevery.Perspectives.Controllers {
    public class PerspectiveController : ApiController {
        private readonly IContentManager _contentManager;
        private readonly IMenuService _menuService;
        private readonly INavigationManager _navigationManager;

        public PerspectiveController(IMenuService menuService,
            IContentManager contentManager,
            ICoeveryServices coeveryServices,
            INavigationManager navigationManager) {
            _contentManager = contentManager;
            Services = coeveryServices;
            _menuService = menuService;
            _navigationManager = navigationManager;
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }
        public ICoeveryServices Services { get; private set; }

        // GET api/perspective/perspective
        public object Get(int page, int rows) {
            IEnumerable<TitlePart> menus = Services.ContentManager.Query<TitlePart, TitlePartRecord>().OrderBy(x => x.Title).ForType("Menu").List();
            var query = from menu in menus
                select new {Id = menu.Id, DisplayName = menu.Title};
            var totalRecords = query.Count();
            return new {
                total = Convert.ToInt32(Math.Ceiling((double)totalRecords / rows)),
                page = page,
                records = totalRecords,
                rows = query
            };
        }

        private MenuItemEntry CreateMenuItemEntries(MenuPart menuPart) {
            return new MenuItemEntry {
                MenuItemId = menuPart.Id,
                IsMenuItem = menuPart.Is<MenuItemPart>(),
                Text = menuPart.MenuText,
                Position = menuPart.MenuPosition,
                Url = menuPart.Is<MenuItemPart>()
                    ? menuPart.As<MenuItemPart>().Url
                    : _navigationManager.GetUrl(null, Services.ContentManager.GetItemMetadata(menuPart).DisplayRouteValues),
                ContentItem = menuPart.ContentItem,
            };
        }

        public IEnumerable<object> Get(int id) {
            var menuEntitys = _menuService.GetMenuParts(id).Select(CreateMenuItemEntries)
                .OrderBy(menuPartEntry => menuPartEntry.Position, new FlatPositionComparer()).ToList();
            var query = from menuEntry in menuEntitys
                select new {Id = menuEntry.ContentItem.Id, DisplayName = menuEntry.Text,};
            var queryList = query.ToList();
            return queryList;
        }

        public void Delete(int id) {
            var contentItem = _contentManager.Get(id, VersionOptions.Latest);
            if (contentItem != null) {
                _contentManager.Remove(contentItem);
            }
        }
    }
}