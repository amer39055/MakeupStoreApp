using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeupStoreAppUI.Components
{
    /// <summary>
    /// this Class is a reusable component that can be used with all forms of project 
    /// Controls :
    /// two buttons @btnSearch , @btnClear
    /// three radio buttons : @rdbCodeFilter, @rdbTitleFilter, @rdbCategoryFilter
    /// </summary>
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // trim entry and convert to lower then return it to be used for search
            string searchEntry = txtSearchEntry.Text.Trim().ToLower().ToString();
            SearchItem(searchEntry);
            
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchEntry.Text = "";
        }

        /// <summary>
        /// helper method that will check the entry to avoid any exemptions or miskeys
        /// you can change method by overriding it in form to suit the parent form that it will perform on.
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        
        public virtual string SearchItem(string entry)
        {
            return entry == null ? null : entry;
            //here you can write search code to represent results in grid
            // you should override this method 
        }

        /// <summary>
        /// this method will check filters radio buttons
        /// </summary>
        /// <param name="filters"></param>
        /// <returns>int value that will translated into parameter for stored procedurs </returns>
        /// 
        public int FilterKey(List<RadioButton> filters)
        {
            // TODO : this method need more work to get values of filters 
            // then pass them to btnSearch_click method 
             // for now it returns 0        
            return 0;
        }
    }
}
