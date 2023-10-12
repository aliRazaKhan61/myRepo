using System;
using System.Collections.Generic;
using System.Text;

namespace Luna.Recruitment.VisaProcessing.Data.DTO
{
    public class DataTableAjaxPostModel
    {
        public int draw { get; set; }             // The draw count - used by DataTables
        public int start { get; set; }            // The starting record index for the current page
        public int length { get; set; }           // The number of records to display per page
        public Search search { get; set; }        // The search criteria

        // Additional properties or methods can be added if needed

        public class Search
        {
            public string value { get; set; }      // The search value entered by the user
            public bool regex { get; set; }        // Indicates if the search is a regular expression
        }
    }
}
