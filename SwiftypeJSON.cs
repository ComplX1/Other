using Newtonsoft.Json;
using RestSharp.Contrib;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Framework._3rdParty.Swiftype
{
    /// <summary>
    /// Base Class of returned object from swiftype
    /// records: returns a collection of results 
    /// info: auxillory information regarding search
    /// errors: error information returned regarding search
    /// </summary>
    public class SwiftypeResults
    {
        /// <summary>
        /// Gets or sets the records.
        /// </summary>
        /// <value>
        /// The records.
        /// </value>
        public SwiftypeRecords records { get; set; }
        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public SwiftypeInfo info { get; set; }
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public object errors { get; set; }
    }

    /// <summary>
    /// Record holder class
    /// stores different "Doctypes"
    /// in our case its website pages
    /// </summary>
    public class SwiftypeRecords
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public IList<SwiftypeRecordItem> page { get; set; } 
    }

    /// <summary>
    /// single page result from swiftype
    /// </summary>
    public class SwiftypeRecordItem
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public Uri url { get; set; }
        /// <summary>
        /// Gets the prices.
        /// </summary>
        /// <value>
        /// The prices.
        /// </value>
        public IList<PriceInfo> Prices { get; private set; }

        /// <summary>
        /// The _image
        /// </summary>
        public string _image = "/static/img/placeholderImg.gif";
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public string image
        {
            get { return _image; }
            set
            {
                if (value != "http://justflight.ggstatic.com")
                {
                    _image = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        public string Caption { get; set; }

        /// <summary>
        /// Product Format Number
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public byte format { get; set; }

        /// <summary>
        /// Product Status Number
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public byte status { get; set; }

        /// <summary>
        /// Gets the compatibility.
        /// </summary>
        /// <value>
        /// The compatibility.
        /// </value>
        public List<string> compatibility { get; private set; }
        /// <summary>
        /// Sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public object tags
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    compatibility = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    compatibility = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        /// <summary>
        /// Product Code
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string code { get; set; }

        public List<string> platforms { get; private set; }
        public object platform 
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    platforms = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    platforms = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        public List<string> genre { get; private set; }
        public object genres
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    genre = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    genre = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        public List<string> language { get; private set; }
        public object languages
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    language = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    language = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        public List<string> publisher { get; private set; }
        public object publishers
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    publisher = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    publisher = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        public List<string> drm { get; private set; }
        public object drms
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    drm = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    drm = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        public List<string> others { get; private set; }
        public object other
        {
            set
            {

                var singlevalue = value as string;

                if (singlevalue != null)
                {
                    others = new List<string> { value.ToString() };
                }
                else
                {
                    var collection = value as System.Collections.IEnumerable;
                    others = collection
                                    .Cast<object>()
                                    .Select(x => x.ToString())
                                    .ToList();
                }
            }
        }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public string Stock { get; set; }
        /// <summary>
        /// Gets or sets the usd price.
        /// </summary>
        /// <value>
        /// The usd price.
        /// </value>
        public float? USDPrice { get; set; }
        /// <summary>
        /// Gets or sets the GBP price.
        /// </summary>
        /// <value>
        /// The GBP price.
        /// </value>
        public float? GBPPrice { get; set; }
        /// <summary>
        /// Gets or sets the published_at.
        /// </summary>
        /// <value>
        /// The published_at.
        /// </value>
        public DateTime? published_at { get; set; }
        /// <summary>
        /// Gets or sets the subtitle.
        /// </summary>
        /// <value>
        /// The subtitle.
        /// </value>
        public string subtitle { get; set; }
        /// <summary>
        /// Gets or sets the sales.
        /// </summary>
        /// <value>
        /// The sales.
        /// </value>
        public int sales { get; set; }

        /// <summary>
        /// A very delimited string contain prices for the product in format 'GBP=14.99,13.99|EUR=18.99,|USD=19.99,|BRL=36.99,|RUB=419.00,'
        /// Pipes separates currency,each part then  further separated into currency code, price and RRP price  - separated by a comma. 
        /// </summary>
        /// <value>
        /// The delimited price string
        /// </value>
        public string info
        {
            set
            {
                string allPrices = string.Empty;

                //bit of a hack job as JT contains 'ProductPrices before the colon in the string and GG and JF don't!!
                if (value.Contains(":"))
                {
                    allPrices = String.Join(":", value.Split(':').Skip(1).ToArray());
                }
                else
                {
                    allPrices = value;   
                }

                var allCurrencies = allPrices.Split('|');


                Prices = new List<PriceInfo>();
                foreach (var currency in allCurrencies)
                {
                    if (currency != String.Empty)
                    {
                        PriceInfo currencyPrice = new PriceInfo();

                        //split element into code and prices
                        currencyPrice.Code = currency.Split('=')[0];
                        string productPrices = currency.Split('=')[1];

                        //split prices into price and RRP
                        currencyPrice.Price = productPrices.Split(',')[0];
                        currencyPrice.RRP = productPrices.Split(',')[1];

                        Prices.Add(currencyPrice);
                    }
                }
            }
        }

        /// <summary>
        /// Simplified version of ProductPrices object
        /// stores currency code, price and RRP
        /// </summary>
        public class PriceInfo
        {
            /// <summary>
            /// Gets or sets the code.
            /// </summary>
            /// <value>
            /// The code.
            /// </value>
            public string Code { get; set; }
            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public string Price { get; set; }
            /// <summary>
            /// Gets or sets the RRP.
            /// </summary>
            /// <value>
            /// The RRP.
            /// </value>
            public string RRP { get; set; }
        }
    }

    /// <summary>
    /// collection of extra information about search
    /// </summary>
    public class SwiftypeInfo
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public SwiftypeSearchOptions page { get; set; }
    }

    /// <summary>
    /// Search information to sent to /receive from Swiftype
    /// </summary>
    public class SwiftypeSearchOptions
    {
        /// <summary>
        /// The auth_token this is set for our account
        /// </summary>
        public string auth_token = "***********";  //removed from example for security

        /// <summary>
        /// the Search term
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public string q { get; set; }
        public string query { get; set; }
        /// <summary>
        /// Gets or sets the page to display.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        public int page { get; set; }
        /// <summary>
        /// Gets or sets the current_page.
        /// </summary>
        /// <value>
        /// The current_page.
        /// </value>
        public int current_page { get; set; }
        /// <summary>
        /// number of results to display per page
        /// </summary>
        /// <value>
        /// The per_page.
        /// </value>
        public int per_page { get; set; }
        /// <summary>
        /// total number of pages
        /// </summary>
        /// <value>
        /// The num_pages.
        /// </value>
        public int num_pages { get; set; }
        /// <summary>
        /// Gets or sets the total_result_count.
        /// </summary>
        /// <value>
        /// The total_result_count.
        /// </value>
        public int total_result_count { get; set; }
        /// <summary>
        /// Gets or sets the filters.
        /// </summary>
        /// <value>
        /// The filters.
        /// </value>
        public SwiftypeFilter filters { get; set; }
        /// <summary>
        /// Gets or sets the sort_field.
        /// </summary>
        /// <value>
        /// The sort_field.
        /// </value>
        public SwiftypeSortField sort_field { get; set; }
        /// <summary>
        /// Gets or sets the sort_direction.
        /// </summary>
        /// <value>
        /// The sort_direction.
        /// </value>
        public SwiftypeSortDirection sort_direction { get; set; }

        public string spelling { get; set; }

        public SwiftypeSpellingSuggestion spelling_suggestion { get; set; }

        public SwiftypeSearchFields search_fields { get; set; }

        public SwiftypeFunctionalBoosts functional_boosts { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwiftypeSearchOptions"/> class.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="per_page">The per_page.</param>
        /// <param name="searchQuery">The search query.</param>
        /// <param name="currency">The currency.</param>
        public SwiftypeSearchOptions(int pageNumber, int per_page, string searchQuery)
        {
            page = pageNumber;
            this.per_page = per_page;
            q = searchQuery;
            filters = new SwiftypeFilter();
            spelling = "strict";
            search_fields = new SwiftypeSearchFields();
            functional_boosts = new SwiftypeFunctionalBoosts();
        }

        /// <summary>
        /// Sorts the results by.
        /// </summary>
        /// <param name="sort">The sort.</param>
        /// <param name="currency">The currency.</param>
        public void sortResultsBy(Library.EnumsLib.Sorting sort, string currency)
        {
            switch (sort)
            {
                case Library.EnumsLib.Sorting.MostRelevant:
                    break;
                case Library.EnumsLib.Sorting.Title:
                    sort_field = new SwiftypeSortField("title");
                    sort_direction = new SwiftypeSortDirection("asc");
                    break;
                case Library.EnumsLib.Sorting.PriceAsc:
                    sort_field = new SwiftypeSortField(currency.ToUpper() + "Price");
                    sort_direction = new SwiftypeSortDirection("asc");
                    break;
                case Library.EnumsLib.Sorting.PriceDesc:
                    sort_field = new SwiftypeSortField(currency.ToUpper() + "Price");
                    sort_direction = new SwiftypeSortDirection("desc");
                    break;
                case Library.EnumsLib.Sorting.ReleaseDate:
                    sort_field = new SwiftypeSortField("release-date");
                    sort_direction = new SwiftypeSortDirection("desc");
                    break;
                case Library.EnumsLib.Sorting.Sales:
                    sort_field = new SwiftypeSortField("sales");
                    sort_direction = new SwiftypeSortDirection("desc");
                    break;
            }
        }
    }

    /// <summary>
    /// field to search by
    /// </summary>
    public class SwiftypeFunctionalBoosts
    {
        public Dictionary<string,string> page { get; set; }

        public SwiftypeFunctionalBoosts() 
        {
            page = new Dictionary<string,string>();
        }

    }

    /// <summary>
    /// field to search by
    /// </summary>
    public class SwiftypeSearchFields
    {
        public IList<string> page { get; set; }
        public SwiftypeSearchFields()
        {
            page = new List<string>();
        }
        public void addField(string fieldname, int weight)
        {
            page.Add(fieldname+"^"+weight);
        }
    }

    /// <summary>
    /// field to sort by
    /// </summary>
    public class SwiftypeSortField
    {
        public string page { get; set; }
        public SwiftypeSortField(string sortfield)
        {
            page = sortfield;
        }
    }

    /// <summary>
    /// Direction to sort by asc | desc
    /// </summary>
    public class SwiftypeSortDirection
    {
        public string page { get; set; }
        public SwiftypeSortDirection(string sortdirection)
        {
            page = sortdirection;
        }
    }

    /// <summary>
    /// currency field to filter results by
    /// </summary>
    public class SwiftypeFilter
    {
        public Dictionary<string,object> page { get; set; }

        public SwiftypeFilter()
        {
            page = new Dictionary<string, object>();
        }

        public void AddCurrencyFilter(string filterCurrency)
        {
            page[filterCurrency + "Price"] = new SwiftypeFilterRange();
        }
    }

    /// <summary>
    /// Returns a single field to sort results by and doesn't serialise other currencies
    /// allows products to be filtered by currency 
    /// </summary>
    public class SwiftypeFilterField
    {
        public SwiftypeFilterRange USDPrice { get; set; }
        public SwiftypeFilterRange GBPPrice { get; set; }
        public SwiftypeFilterRange EURPrice { get; set; }

        public bool ShouldSerializeUSDPrice()
        {
            return (USDPrice != null);
        }
        public bool ShouldSerializeGBPPrice()
        {
            return (GBPPrice != null);
        }
        public bool ShouldSerializeEURPrice()
        {
            return (EURPrice != null);
        }

        public SwiftypeFilterField(string filterCurrency)
        {
            switch (filterCurrency)
            {
                case "USD":
                    USDPrice = new SwiftypeFilterRange();
                    break;
                case "GBP":
                    GBPPrice = new SwiftypeFilterRange();
                    break;
                case "EUR":
                    EURPrice = new SwiftypeFilterRange();
                    break;
            } 
        }
    }


    /// <summary>
    /// filter between a range of values
    /// from lower bracket
    /// to upper bracket
    /// if value is null limit is undisclosed
    /// </summary>
    public class SwiftypeFilterRange
    {
        public string type = "range";
        public float? from { get; set; }
        public float? to { get; set; }

        public SwiftypeFilterRange()
        {
            from = 0.00f;
        }
    }

    public class SwiftypeSpellingSuggestion
    {
        public string text { get; set;}
        public float score { get; set; }
    }

}
