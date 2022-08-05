﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class MyPage : System.Web.UI.Page
    {
        private List<MyEvent> myEvents;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["MyEvents"] = new List<MyEvent>();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateEvents();
            BindEvents();
        }

        private void UpdateEvents()
        {
            if (Session["MyEvents"] != null)
            {
                myEvents = (List<MyEvent>)Session["MyEvents"];
            }
            else
            {
                myEvents = new List<MyEvent>();
            }

            myEvents.Add(new MyEvent(txtEventName.Text, calendarEvents.SelectedDate));
            Session["MyEvents"] = myEvents;
        }

        private void BindEvents()
        {
            rptEvents.DataSource = myEvents;
            rptEvents.DataBind();
        }
    }

    public class MyEvent
    {
        public string EventName
        {
            get;
            private set;
        }

        public string EventDate {
            get;
            private set;
        }

        public MyEvent(string evtName, DateTime evtDate)
        {
            EventName = evtName;
            EventDate = evtDate.ToShortDateString();
        }
    }
}