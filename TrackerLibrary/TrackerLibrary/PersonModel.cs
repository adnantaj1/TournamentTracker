using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// the  first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// the lastname of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// emailaddress of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// cell number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
