using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyErp.Models;

namespace MyErp.Models {

    public class DataSource {
        
        public static IList<Country> Countries { get; }
        public static IList<Incoterm> Incoterms { get; }
        public static IList<Currency> Currencies { get; }
        public static IList<MatClass> MatClasses { get; }
        public static IList<MatClass> MatClassesL { get; }
        public static IList<MatType> MatTypes { get; }
        public static IList<MeasureU> MeasureUs { get; }
        public static IList<TimeU> TimeUs { get; }
        public static IList<AppRol> AppRols { get; }
        public static IList<WDay> WDays { get; }
        public static IList<SPOStat> SPOStatus { get; }
        public static IList<CPlanStat> CPlanStatus { get; }
        static DataSource() {
            Countries = new List<Country>();
            Countries.Add(new Country("ES", "Spain"));
            Countries.Add(new Country("PT", "Portugal"));            
            Countries.Add(new Country("USA", "United States"));
            Countries.Add(new Country("CAN", "Canada"));
            Countries.Add(new Country("CHN", "China"));
            Countries.Add(new Country("IND", "India"));

            Incoterms = new List<Incoterm>();
            Incoterms.Add(new Incoterm("EXW", "Ex Works"));
            Incoterms.Add(new Incoterm("FAS", "Free alongside ship"));            
            Incoterms.Add(new Incoterm("FOB", "Free on board"));
            Incoterms.Add(new Incoterm("FCA", "Free carrier"));
            Incoterms.Add(new Incoterm("CFR", "Cost and freight"));
            Incoterms.Add(new Incoterm("CIF", "Cost insurance and freight"));
            Incoterms.Add(new Incoterm("CPT", "Carriage paid to"));
            Incoterms.Add(new Incoterm("CIP", "Carriage and insurance paid"));
            Incoterms.Add(new Incoterm("DPU", "Delivered at Place and Unloaded"));
            Incoterms.Add(new Incoterm("DAP", "Delivered At Place"));
            Incoterms.Add(new Incoterm("DDP", "Delivered Duty Paid"));

            Currencies = new List<Currency>();
            Currencies.Add(new Currency("EUR", "Euro"));
            Currencies.Add(new Currency("USD", "Dolar USA"));            
            Currencies.Add(new Currency("CND", "Dolar Can"));
            Currencies.Add(new Currency("GBP", "Libra esterlina"));
            Currencies.Add(new Currency("JPY", "Yen Japones"));

            MatClasses = new List<MatClass>();
            MatClasses.Add(new MatClass("FG", "Finish Good"));
            MatClasses.Add(new MatClass("RM", "Raw Material"));            
            MatClasses.Add(new MatClass("SF", "Sub Assembly"));

            MatClassesL = new List<MatClass>();
            MatClassesL.Add(new MatClass("--", "Select a Material Class"));
            MatClassesL.Add(new MatClass("FG", "Finish Good"));
            MatClassesL.Add(new MatClass("RM", "Raw Material"));            
            MatClassesL.Add(new MatClass("SF", "Sub Assembly"));


            MatTypes = new List<MatType>();
            MatTypes.Add(new MatType("T1", "Mat Type 1"));
            MatTypes.Add(new MatType("T2", "Mat Type 2"));            
            MatTypes.Add(new MatType("T3", "Mat Type 3"));

            MeasureUs = new List<MeasureU>();
            MeasureUs.Add(new MeasureU("UN", "Unit (PCE)"));
            MeasureUs.Add(new MeasureU("M", "Meters"));            
            MeasureUs.Add(new MeasureU("KG", "Kilograms"));
            MeasureUs.Add(new MeasureU("M2", "Square Meters")); 

            TimeUs = new List<TimeU>();
            TimeUs.Add(new TimeU("H", "Hour "));
            TimeUs.Add(new TimeU("M", "Minute"));            
            TimeUs.Add(new TimeU("S", "Second"));
            TimeUs.Add(new TimeU("D", "Day"));        
            TimeUs.Add(new TimeU("Mo", "Month"));        
            TimeUs.Add(new TimeU("Y", "Year"));        

            AppRols = new List<AppRol>();
            AppRols.Add(new AppRol("Select_Role", "Select_Role"));
            AppRols.Add(new AppRol("Administrator", "Administrator"));
            AppRols.Add(new AppRol("Customer", "Customer"));            
            AppRols.Add(new AppRol("Engineer", "Engineer"));
            AppRols.Add(new AppRol("MRP", "MRP"));        
            AppRols.Add(new AppRol("Organization", "Organization"));        
            AppRols.Add(new AppRol("HR", "HR"));        
            AppRols.Add(new AppRol("Supplier", "Supplier"));        
            AppRols.Add(new AppRol("Logistic", "Logistic"));        

            WDays = new List<WDay>();
            WDays.Add(new WDay(1, "Sunday"));
            WDays.Add(new WDay(2, "Monday"));
            WDays.Add(new WDay(3, "Tuesday"));
            WDays.Add(new WDay(4, "Wednesday"));
            WDays.Add(new WDay(5, "Tursday"));
            WDays.Add(new WDay(6, "Friday"));
            WDays.Add(new WDay(7, "Saturday"));

            SPOStatus = new List<SPOStat>();
            SPOStatus.Add(new SPOStat(1, "Active"));
            SPOStatus.Add(new SPOStat(2, "Revised"));
            SPOStatus.Add(new SPOStat(3, "OnStudy"));

            CPlanStatus = new List<CPlanStat>();
            CPlanStatus.Add(new CPlanStat("1", "Prevision"));
            CPlanStatus.Add(new CPlanStat("2", "Firm"));
            CPlanStatus.Add(new CPlanStat("3", "Updated"));

            }


        public static IList<Country> GetCountry() {
            var result = Countries;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }
        public static IList<Incoterm> GetIncoterm() {
            var result = Incoterms;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }
        public static IList<Currency> GetCurrency() {
            var result = Currencies;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }


        public static IList<MatClass> GetMCatlass() {
            var result = MatClasses;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }


        public static IList<MatClass> GetMCatlassL() {
            var result = MatClassesL;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<MatType> GetMatType() {
            var result = MatTypes;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<MeasureU> GetMatUnits() {
            var result = MeasureUs;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<TimeU> GetTimeUnits() {
            var result = TimeUs;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<AppRol> GetAppRols() {
            var result = AppRols;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<WDay> GetWDays() {
            var result = WDays;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<SPOStat> GetSPOStatus() {
            var result = SPOStatus;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static IList<CPlanStat> GetCPlanStatus() {
            var result = CPlanStatus;
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }
        /*
        public static List<Referencia> GetRefSup(int? id) {
            MyErpDBContext _dbContext=new MyErpDBContext();
 
             List<Referencia> result = from p in _dbContext.TSProducts 
                        orderby p.ProdRefer
                        select new Referencia{p.ProdId,p.ProdRefer};
            List<Referencia> resulta = result.ToList();
            return resulta;
        }
        */
    }
}