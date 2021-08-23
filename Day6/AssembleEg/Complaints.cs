using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembleEg
{
    class Complaints
    {
		public int complaintID { get; set; }
		public DateTime dateReceived { get; set; }
		public String product { get; set; }
		private String subProduct;
		private String issue;
		private String subIssue;
		private String company;
		private String state;
		private String zipCode;
		private String submittedVia;
		private DateTime dateSentToCompany;
		public String companyResponse { get; }
		private bool timelyResponse;
		private bool consumerDisputed;


		public  DateTime convertToDate(String date)
		{
		
			return DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.CurrentCulture);

			//return DateTime.Parse(date);


		}
	}
}
