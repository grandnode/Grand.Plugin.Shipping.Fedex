﻿using System.Collections.Generic;
using System.Web.Mvc;
using Grand.Web.Framework;

namespace Grand.Plugin.Shipping.Fedex.Models
{
    public class FedexShippingModel
    {
        public FedexShippingModel()
        {
            CarrierServicesOffered = new List<string>();
            AvailableCarrierServices = new List<string>();
        }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.Url")]
        public string Url { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.Key")]
        public string Key { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.Password")]
        public string Password { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.AccountNumber")]
        public string AccountNumber { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.MeterNumber")]
        public string MeterNumber { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.UseResidentialRates")]
        public bool UseResidentialRates { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.ApplyDiscounts")]
        public bool ApplyDiscounts { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }

        public IList<string> CarrierServicesOffered { get; set; }
        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.CarrierServices")]
        public IList<string> AvailableCarrierServices { get; set; }
        public string[] CheckedCarrierServices { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.PassDimensions")]
        public bool PassDimensions { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.PackingPackageVolume")]
        public int PackingPackageVolume { get; set; }

        public int PackingType { get; set; }
        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.PackingType")]
        public SelectList PackingTypeValues { get; set; }

        public int DropoffType { get; set; }
        [GrandResourceDisplayName("Plugins.Shipping.Fedex.Fields.DropoffType")]
        public SelectList AvailableDropOffTypes { get; set; }
    }
}