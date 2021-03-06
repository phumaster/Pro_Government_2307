﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using DevExpress.Utils;
using DataAccess;
using Microsoft.VisualBasic.PowerPacks;
using BussinessLogic;

namespace RoomManager
{
    public partial class uc_RoomStatusItem : UserControl
    {
        public RoomExtStatusEN Datasource;
        public int StatusButtonPopup = 0;

        private Color  rectangleShape_BackColor ;
        private Color  rectangleShape_BorderColor;

        private Color  lblSku_BackColor;
        private Color lblSku_ForeColor ;

        private string Mess_Qua_han = "Quá hạn";
        private string Mess_Tra_phong = "Trả phòng lúc ";
        private string Mess_Mai_tra_phong = "Mai trả phòng lúc ";



        public RoomExtStatusEN From = new RoomExtStatusEN();
        public RoomExtStatusEN To = new RoomExtStatusEN();



        public uc_RoomStatusItem()
        {
            InitializeComponent();
        }
       
        public uc_RoomStatusItem(RoomExtStatusEN Datasource)
        {
            InitializeComponent();
            this.Datasource = Datasource;
            
            //string a =Datasource.Sku;
            //string b = Datasource.Code;
            this.From = Datasource;

            if (Datasource.Disable == true)
            {
                this.rectangleShape_BackColor = System.Drawing.Color.DarkRed;
                this.rectangleShape_BorderColor = System.Drawing.Color.Maroon;

                this.lblSku_BackColor = System.Drawing.Color.DarkRed;
                this.lblSku_ForeColor = System.Drawing.Color.Maroon;
                

            }
            else if (Datasource.Disable == false)
            {
                if (Datasource.RoomStatus == 0)
                {
                    this.rectangleShape_BackColor = System.Drawing.Color.Gainsboro;
                    this.rectangleShape_BorderColor = System.Drawing.Color.WhiteSmoke;

                    this.lblSku_BackColor = System.Drawing.Color.Gainsboro;
                    this.lblSku_ForeColor = System.Drawing.Color.WhiteSmoke;
                }

                if (Datasource.RoomStatus == 1) // Verifi 
                {
                    this.rectangleShape_BackColor = System.Drawing.Color.DarkRed;
                    this.rectangleShape_BorderColor = System.Drawing.Color.Maroon;

                    this.lblSku_BackColor = System.Drawing.Color.DarkRed;
                    this.lblSku_ForeColor = System.Drawing.Color.Maroon;
                }
                if (Datasource.RoomStatus == 2)
                {
                    this.rectangleShape_BackColor = System.Drawing.Color.Gold;
                    this.rectangleShape_BorderColor = System.Drawing.Color.Goldenrod;

                    this.lblSku_BackColor = System.Drawing.Color.Gold;
                    this.lblSku_ForeColor = System.Drawing.Color.Goldenrod;


                }
                if (Datasource.RoomStatus == 3) // Dang o
                {
                    this.rectangleShape_BackColor = System.Drawing.Color.SkyBlue;
                    this.rectangleShape_BorderColor = System.Drawing.Color.Teal;

                    this.lblSku_BackColor = System.Drawing.Color.SkyBlue;
                    this.lblSku_ForeColor = System.Drawing.Color.WhiteSmoke;
                }
                if (Datasource.RoomStatus == 5)
                {
                    this.rectangleShape_BackColor = System.Drawing.Color.Gold;
                    this.rectangleShape_BorderColor = System.Drawing.Color.Goldenrod;

                    this.lblSku_BackColor = System.Drawing.Color.Gold;
                    this.lblSku_ForeColor = System.Drawing.Color.Goldenrod;

                }
            }

            lblSku.ForeColor = lblSku_ForeColor;
            lblSku.BackColor = lblSku_BackColor;

            rectangleShape1.BorderColor = rectangleShape_BorderColor;
            rectangleShape1.BackColor = rectangleShape_BackColor;

            this.LoadWarning();
        }


        public void DataBind()
        {
            lblSku.Text = this.Datasource.Sku;
            Size aSize = new System.Drawing.Size(rectangleShape1.Size.Width, lbWarning.Size.Height);
            lbWarning.Size = aSize;
        }

        private void uc_RoomStatusItem_Load(object sender, EventArgs e)
        {
            this.DataBind();
            
        }

        public int CountMemberInRoom(int IDBookingRoom)
        {
            BookingRoomsMembersBO aBookingRoomsMembersBO = new BookingRoomsMembersBO();
            return aBookingRoomsMembersBO.Select_ByIDBookingRoom(IDBookingRoom).Count();
        }

        private void LoadWarning()
        {
            string Warning = "";
            TimeSpan aRank = this.Datasource.CheckOutPlan - DateTime.Now;
            if (this.Datasource.Disable == true)
            {
                Warning = "TẠM KHÓA";

                this.lbWarning.Text = Warning;
                this.lbWarning.Visible = true;
                this.lbWarning.BackColor = rectangleShape1.BackColor;
                this.lbWarning.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                if (this.Datasource.RoomStatus == 3 /*Dang check In*/)
                {

                    int compare = DateTime.Compare(this.Datasource.CheckOutPlan.Date, DateTime.Today);
                    if (compare == 0)
                    {
                        Warning = this.Mess_Tra_phong + this.Datasource.CheckOutPlan.TimeOfDay.Hours + ":" + this.Datasource.CheckOutPlan.TimeOfDay.Minutes;

                        this.lbWarning.Text = this.CountMemberInRoom(this.Datasource.BookingRooms_ID) + "\n" + this.Datasource.CheckInActual.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy") + "\n" + Warning;
                        this.lbWarning.Visible = true;
                        this.lbWarning.BackColor = rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                    else if (compare > 0 && aRank.TotalHours < 36)
                    {

                        Warning = this.Mess_Mai_tra_phong + this.Datasource.CheckOutPlan.TimeOfDay.Hours + ":" + this.Datasource.CheckOutPlan.TimeOfDay.Minutes;
                        this.lbWarning.Text = this.CountMemberInRoom(this.Datasource.BookingRooms_ID) + "\n" + this.Datasource.CheckInActual.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy") + "\n" + Warning;
                        this.lbWarning.Visible = true;
                        this.lbWarning.BackColor = rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                    else if (compare > 0 && aRank.TotalHours >= 36)
                    {


                        this.lbWarning.Text = this.CountMemberInRoom(this.Datasource.BookingRooms_ID) + "\n" + this.Datasource.CheckInActual.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy");
                        this.lbWarning.Visible = true;
                        this.lbWarning.BackColor = rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                    else
                    {
                        this.lbWarning.Text = this.CountMemberInRoom(this.Datasource.BookingRooms_ID) + "\n" + this.Datasource.CheckInActual.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy") + "\n" + this.Mess_Qua_han;
                        this.lbWarning.Visible = true;
                        this.lbWarning.BackColor = this.rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                }

                if (this.Datasource.RoomStatus == 5)
                {
                    int compare = DateTime.Compare(this.Datasource.CheckOutPlan.Date, DateTime.Today);
                    if (compare >= 0)
                    {
                        this.lbWarning.Text = this.Datasource.CheckInActual.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy");
                        this.lbWarning.Visible = true;

                        this.lbWarning.BackColor = rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                }

                if (this.Datasource.RoomStatus == 2)
                {
                    int compare = DateTime.Compare(this.Datasource.CheckInPlan.Date, DateTime.Today);
                    if (compare >= 0)
                    {
                        this.lbWarning.Text = this.Datasource.CheckInPlan.ToString("dd/MM/yyyy") + "\n" + this.Datasource.CheckOutPlan.ToString("dd/MM/yyyy");
                        this.lbWarning.Visible = true;

                        this.lbWarning.BackColor = rectangleShape1.BackColor;
                        this.lbWarning.ForeColor = lblSku_ForeColor;
                    }
                }
            }
        }

        private void rectangleShape1_MouseEnter(object sender, EventArgs e)
        {
            this.ColorActive();
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            this.ColorDeactive();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            this.OpenPopup();
        }

        private void lblSku_Click(object sender, EventArgs e)
        {
            this.OpenPopup();
        }

        private void lblSku_MouseEnter(object sender, EventArgs e)
        {
            this.ColorActive();
        }

        private void lblSku_MouseLeave(object sender, EventArgs e)
        {
            this.ColorDeactive();
        }

        private void OpenPopup()
        {
            if (this.Datasource.RoomStatus >=0 )
            {

                if (this.Datasource.RoomStatus == 1 )
                {
                    uc_Tooltip_StatusRoom_1 aToolTip_1 = new uc_Tooltip_StatusRoom_1();

                    aToolTip_1.Datasource = this.Datasource;
                    aToolTip_1.StatusButtonPopup = this.StatusButtonPopup;
                    aToolTip_1.DataBind();
                    aToolTip_1.ShowDialog();
                }
                if (this.Datasource.RoomStatus == 2)
                {
                    // them 2 lan .Parent . . . luc dau 10 lan
                    frmMain afrmMain = (frmMain)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    uc_Tooltip_StatusRoom_2 aToolTip_2 = new uc_Tooltip_StatusRoom_2(afrmMain);

                    aToolTip_2.Datasource = this.Datasource;
                    aToolTip_2.StatusButtonPopup = this.StatusButtonPopup;
                    aToolTip_2.DataBind();
                    aToolTip_2.ShowDialog();
                }
                else if (this.Datasource.RoomStatus == 3)
                {
                    // them 2 lan .Parent . . . luc dau 10 lan
                    frmMain afrmMain = (frmMain)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    
                    if (this.lbWarning.Text != this.Mess_Qua_han)
                    {
                        uc_Tooltip_StatusRoom_3 aToolTip_3 = new uc_Tooltip_StatusRoom_3(afrmMain);
                        aToolTip_3.Datasource = this.Datasource;
                        aToolTip_3.StatusButtonPopup = this.StatusButtonPopup;
                        aToolTip_3.DataBind();
                        aToolTip_3.ShowDialog();
                    }
                    else
                    {
                        uc_Tooltip_StatusRoom_3_OutOfDate aToolTip_3 = new uc_Tooltip_StatusRoom_3_OutOfDate(afrmMain);
                        aToolTip_3.Datasource = this.Datasource;
                        aToolTip_3.StatusButtonPopup = this.StatusButtonPopup;
                        aToolTip_3.DataBind();
                        aToolTip_3.ShowDialog();
                    }
                }
                else if (this.Datasource.RoomStatus == 5)
                {
                    // them 2 lan .Parent . . . luc dau 10 lan
                    frmMain afrmMain = (frmMain)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    uc_Tooltip_StatusRoom_5 aToolTip_5 = new uc_Tooltip_StatusRoom_5(afrmMain);
                    
                    aToolTip_5.Datasource = this.Datasource;
                    aToolTip_5.StatusButtonPopup = this.StatusButtonPopup;
                    aToolTip_5.DataBind();
                    aToolTip_5.ShowDialog();
                }

                else if (this.Datasource.RoomStatus == 0)
                {
                    // them 2 lan .Parent . . . luc dau 10 lan
                    frmMain afrmMain = (frmMain)this.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                    uc_Tooltip_StatusRoom_0 aToolTip_0 = new uc_Tooltip_StatusRoom_0(afrmMain);
                    
                    aToolTip_0.Datasource = this.Datasource;
                    aToolTip_0.StatusButtonPopup = this.StatusButtonPopup;
                    aToolTip_0.DataBind();
                    aToolTip_0.ShowDialog();
                }
            }

        }
        private void ColorActive()
        {
            lblSku.ForeColor = Color.FromArgb(lblSku_ForeColor.R * 80 / 100, lblSku_ForeColor.G * 80 / 100, lblSku_ForeColor.B * 80 / 100);
            lblSku.BackColor = Color.FromArgb(lblSku_BackColor.R * 80 / 100, lblSku_BackColor.G * 80 / 100, lblSku_BackColor.B * 80 / 100);


            rectangleShape1.BorderColor = Color.FromArgb(rectangleShape_BorderColor.R * 80 / 100, rectangleShape_BorderColor.G * 80 / 100, rectangleShape_BorderColor.B * 80 / 100);
            rectangleShape1.BackColor = Color.FromArgb(rectangleShape_BackColor.R * 80 / 100, rectangleShape_BackColor.G * 80 / 100, rectangleShape_BackColor.B * 80 / 100);

            rectangleShape1.BorderWidth = 5;
            rectangleShape1.Refresh();
        }
        private void ColorDeactive()
        {
            lblSku.ForeColor = lblSku_ForeColor;
            lblSku.BackColor = lblSku_BackColor;

            rectangleShape1.BorderColor = rectangleShape_BorderColor;
            rectangleShape1.BackColor = rectangleShape_BackColor;
            rectangleShape1.BorderWidth = 5;
            rectangleShape1.Refresh();
        }

        private void lbWarning_Click(object sender, EventArgs e)
        {
            this.OpenPopup();
        }

        private void lblSku_Click_1(object sender, EventArgs e)
        {
            this.OpenPopup();
        }

        private void uc_RoomStatusItem_Click(object sender, EventArgs e)
        {
            this.OpenPopup();
        }



    }
}
