﻿using System;
using Coevery;
using Coevery.ContentManagement;
using Coevery.ContentManagement.Drivers;
using Coevery.ContentManagement.Handlers;
using Coevery.Fields.Fields;
using Coevery.Fields.Settings;
using Coevery.Localization;
using Coevery.Utility.Extensions;

namespace Coevery.Fields.Drivers {
    public class TextFieldDriver : ContentFieldDriver<TextField> {
        public ICoeveryServices Services { get; set; }
        private const string TemplateName = "Fields/Text.Edit";

        public TextFieldDriver(ICoeveryServices services) {
            Services = services;
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        private static string GetPrefix(ContentField field, ContentPart part) {
            return part.PartDefinition.Name + "." + field.Name;
        }

        private static string GetDifferentiator(TextField field, ContentPart part) {
            return field.Name;
        }

        protected override void GetContentItemMetadata(ContentPart part, TextField field, ContentItemMetadata metadata) {
            var model=field.PartFieldDefinition.Settings.GetModel<TextFieldSettings>();

            if (model.IsDispalyField) {
                metadata.DisplayText = field.Value;
            }
        }

        protected override DriverResult Display(ContentPart part, TextField field, string displayType, dynamic shapeHelper) {
            return ContentShape("Fields_Text", GetDifferentiator(field, part), () => {
                var settings = field.PartFieldDefinition.Settings.GetModel<TextFieldSettings>();
                return shapeHelper.Fields_Text().Settings(settings);
            });
        }

        protected override DriverResult Editor(ContentPart part, TextField field, dynamic shapeHelper) {
            return ContentShape("Fields_Text_Edit", GetDifferentiator(field, part),
                () => shapeHelper.EditorTemplate(TemplateName: TemplateName, Model: field, Prefix: GetPrefix(field, part)));
        }

        protected override DriverResult Editor(ContentPart part, TextField field, IUpdateModel updater, dynamic shapeHelper) {
            if (updater.TryUpdateModel(field, GetPrefix(field, part), null, null)) {
                var settings = field.PartFieldDefinition.Settings.GetModel<TextFieldSettings>();
                if (settings.Required && string.IsNullOrWhiteSpace(field.Value)) {
                    updater.AddModelError(GetPrefix(field, part), T("The field {0} is mandatory.", T(field.DisplayName)));
                }
                if (field.Value.Length > settings.MaxLength) {
                    updater.AddModelError(GetPrefix(field, part), T("The field {0} value exceed max length.", T(field.DisplayName)));
                }
            }
            return Editor(part, field, shapeHelper);
        }

        protected override void Importing(ContentPart part, TextField field, ImportContentContext context) {
            context.ImportAttribute(field.FieldDefinition.Name + "." + field.Name, "Value", v => field.Value = v);
        }

        protected override void Exporting(ContentPart part, TextField field, ExportContentContext context) {
            context.Element(field.FieldDefinition.Name + "." + field.Name).SetAttributeValue("Value", field.Value);
        }

        protected override void Describe(DescribeMembersContext context) {
            context
                .Member(null, typeof(string), null, T("The value of the field."));
        }
    }
}
