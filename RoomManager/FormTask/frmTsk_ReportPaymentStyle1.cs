﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entity;
using BussinessLogic;
using DataAccess;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;

namespace RoomManager
{
    public partial class frmTsk_ReportPaymentStyle1 : DevExpress.XtraEditors.XtraForm
    {
        string CompanyName,Address,NameCustomerGroup,InvoiceNumber;
        DateTime FirstDate;
        DateTime LastDate;
        decimal? BookingHMoney, BookingRMoney = 0;
        int IDBookingR = 0;
        public frmTsk_ReportPaymentStyle1()
        {
            InitializeComponent();
        }
        public frmTsk_ReportPaymentStyle1(List<RptPaymentStyle1_ForDisplay> aListData, List<ServiceGroups> aListServiceGroups, string CompanyName, string Address, string NameCustomerGroup, string InvoiceNumber
            , DateTime FirstDate, DateTime LastDate, decimal? BookingHMoney, decimal? BookingRMoney,int IDBookingR)
        {
            InitializeComponent();
            this.aListServiceGroups.AddRange(aListServiceGroups);
            this.CompanyName = CompanyName;
            this.Address = Address;
            this.NameCustomerGroup = NameCustomerGroup;
            this.InvoiceNumber = InvoiceNumber;
            this.FirstDate = FirstDate;
            this.LastDate = LastDate;
            this.BookingHMoney = BookingHMoney;
            this.BookingRMoney = BookingRMoney;
            this.IDBookingR = IDBookingR;
            RptPaymentStyle1_ForPrint aTemp;
            foreach (RptPaymentStyle1_ForDisplay aItem in aListData)
            {
                aTemp = new RptPaymentStyle1_ForPrint();
                aTemp.SetValue(aItem);
                aListRet.Add(aTemp);
            }
            
        }
        public List<RptPaymentStyle1_ForPrint> aListRet = new List<RptPaymentStyle1_ForPrint>();
        //public List<int> aListIDServiceGroup = new List<int>();
        public List<ServiceGroups> aListServiceGroups = new List<ServiceGroups>();
        private void frmTsk_ReportPaymentStyle1_Load(object sender, EventArgs e)
        {
            ServiceGroupsBO aServiceGroupsBO = new ServiceGroupsBO();
            //List<ServiceGroups> aList = aServiceGroupsBO.Sel_all().Where(p=>aListIDServiceGroup.Contains(p.ID)).ToList();
           

            //GridColumn aCol = new GridColumn();
            //aCol.Caption = "Ngày";
            //aCol.FieldName = "Date";
            //aCol.Visible = true;
            //this.gridView1.Columns.Add(aCol);

            //aCol = new GridColumn();
            //aCol.Caption = "Ghi chú";
            //aCol.FieldName = "Note";
            //aCol.Visible = true;
            //this.gridView1.Columns.Add(aCol);

            //aCol = new GridColumn();
            //aCol.Caption = "Số người";
            //aCol.FieldName = "CountCustomerInGroup";
            //aCol.DisplayFormat.FormatType = FormatType.Numeric;
            //aCol.DisplayFormat.FormatString = "{0:0,0}";
            //aCol.Visible = true;
            //this.gridView1.Columns.Add(aCol);

            //aCol = new GridColumn();
            //aCol.Caption = "Tiền phòng";
            //aCol.FieldName = "Room_Fee";
            //aCol.DisplayFormat.FormatType = FormatType.Numeric;
            //aCol.DisplayFormat.FormatString = "{0:0,0}";
            //aCol.Visible = true;
            //this.gridView1.Columns.Add(aCol);

            //aCol = new GridColumn();
            //aCol.Caption = "Tiền hội trường";
            //aCol.FieldName = "Hall_Fee";
            //aCol.DisplayFormat.FormatType = FormatType.Numeric;
            //aCol.DisplayFormat.FormatString = "{0:0,0}";
            //aCol.Visible = true;
            //this.gridView1.Columns.Add(aCol);

            GridColumn aCol = new GridColumn();
            for (int i = 0; i < this.aListServiceGroups.Count ; i++)
            {
                ServiceGroups aItem = aListServiceGroups[i];

                    aCol = new GridColumn();
                    aCol.Caption = aItem.Name;
                    int tempt =  2 + i ;
                    aCol.FieldName = "ServiceGroup"+ tempt +"_Fee";
                    aCol.DisplayFormat.FormatType = FormatType.Numeric;
                    aCol.DisplayFormat.FormatString = "{0:0,0}";
                    aCol.Visible = true;
                    this.grvReportPaymentStyle1.Columns.Add(aCol);
              
            }

            this.dgvReportPaymentStyle1.MainView = this.grvReportPaymentStyle1;
            this.dgvReportPaymentStyle1.DataSource = this.aListRet;
            this.cbbDiv.Properties.Items.Add(1);
            this.cbbDiv.Properties.Items.Add(2);
            this.cbbDiv.Properties.Items.Add(3);
            this.cbbDiv.Properties.Items.Add(4);
            this.cbbDiv.Properties.Items.Add(5);
            this.cbbDiv.SelectedIndex= 0;

        }

        private void btnPrintGroupPayment_Click(object sender, EventArgs e)
        {
            int Div = int.Parse(cbbDiv.EditValue.ToString());
            frmRpt_GroupPayment_Rs afrmRpt_GroupPayment_Rs = new frmRpt_GroupPayment_Rs(this.aListRet, CompanyName, Address, NameCustomerGroup, InvoiceNumber, FirstDate, LastDate, BookingHMoney, BookingRMoney, this.IDBookingR, Div);
            ReportPrintTool tool = new ReportPrintTool(afrmRpt_GroupPayment_Rs);
            tool.ShowPreview();

        }

        private void btnPrintPersonalPayment_Click(object sender, EventArgs e)
        {
            int Div = int.Parse(cbbDiv.EditValue.ToString());
            frmRpt_PersonalPayment afrmRpt_PersonalPayment = new frmRpt_PersonalPayment(this.aListRet, CompanyName, Address, NameCustomerGroup, InvoiceNumber, FirstDate, LastDate, BookingHMoney, BookingRMoney, IDBookingR, Div);
            ReportPrintTool tool = new ReportPrintTool(afrmRpt_PersonalPayment);
            tool.ShowPreview();
        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            int IDBookingR = Convert.ToInt32(grvReportPaymentStyle1.GetFocusedRowCellValue("BookingRs_ID"));
            string Note = grvReportPaymentStyle1.GetFocusedRowCellValue("Note").ToString();
            int rowindex = grvReportPaymentStyle1.GetFocusedDataSourceRowIndex();
            this.aListRet[rowindex].Note = Note;
            //this.aListRet[].
         
        }
    }
}