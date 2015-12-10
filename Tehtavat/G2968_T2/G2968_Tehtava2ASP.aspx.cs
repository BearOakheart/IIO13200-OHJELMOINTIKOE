using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtavat_G2968_T2_G2968_Tehtava2ASP : System.Web.UI.Page
{
   
    XmlDocument xdoc = new XmlDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadTyontekijat();
    }

    private void LoadTyontekijat()
    {
        DataTable dt = new DataTable();
        DataColumn col = new DataColumn();
        dt.Columns.Add("etunimi", typeof(string));
        dt.Columns.Add("sukunimi", typeof(string));
        dt.Columns.Add("numero", typeof(Int32));
        dt.Columns.Add("tyosuhde", typeof(string));
        dt.Columns.Add("palkka", typeof(Int32));

        // ladataan polku webconfigista
        String tyontekijatXml = ConfigurationManager.AppSettings["tyontekijat"];
        xdoc.Load(Server.MapPath(tyontekijatXml));


        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string etunimi = node["etunimi"].InnerText;
            string sukunimi = node["sukunimi"].InnerText;
            int numero = Convert.ToInt32(node["numero"].InnerText);
            string tyosuhde = node["tyosuhde"].InnerText;
            int palkka = Convert.ToInt32(node["palkka"].InnerText);

            dt.Rows.Add(etunimi,sukunimi, numero, tyosuhde, palkka);
        }



        GridView1.DataSource = dt;
        GridView1.DataBind();

        object Kokonaispalkka;
        Kokonaispalkka = dt.Compute("Sum(palkka)", "");
        int palkkaAll = Convert.ToInt32(Kokonaispalkka);

        int tyontekijoita = dt.Rows.Count;
        Label2.Text = "Yhteensä " + tyontekijoita.ToString() + "työntekijää";

        Label1.Text = "Kokonaispalkka= "+palkkaAll.ToString();
        
        

    }

    private void LoadVakituiset()
    {
        DataTable dt1 = new DataTable();
        DataColumn col = new DataColumn();
        dt1.Columns.Add("etunimi", typeof(string));
        dt1.Columns.Add("sukunimi", typeof(string));
        dt1.Columns.Add("numero", typeof(Int32));
        dt1.Columns.Add("tyosuhde", typeof(string));
        dt1.Columns.Add("palkka", typeof(Int32));

            // ladataan polku webconfigista
            String tyontekijatXml = ConfigurationManager.AppSettings["tyontekijat"];
        xdoc.Load(Server.MapPath(tyontekijatXml));


        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string tyosuhdeXML = node["tyosuhde"].InnerText;
            string vakituinen = "vakituinen";
            if (vakituinen == tyosuhdeXML)
            {

                string etunimi = node["etunimi"].InnerText;
                string sukunimi = node["sukunimi"].InnerText;
                int numero = Convert.ToInt32(node["numero"].InnerText);
                string tyosuhde = node["tyosuhde"].InnerText;
                int palkka = Convert.ToInt32(node["palkka"].InnerText);

                dt1.Rows.Add(etunimi, sukunimi, numero, tyosuhde, palkka);
            }
        }



        GridView1.DataSource = dt1;
        GridView1.DataBind();

        object Kokonaispalkka;
        Kokonaispalkka = dt1.Compute("Sum(palkka)", "");
        int palkkaAll = Convert.ToInt32(Kokonaispalkka);

        Label1.Text = "Kokonaispalkka= " + palkkaAll.ToString();

        int tyontekijoita = dt1.Rows.Count;
        Label2.Text = "Yhteensä " + tyontekijoita.ToString() + "työntekijää";

    }

    private void LoadMaaraaikaiset()
    {
        DataTable dt2 = new DataTable();
        DataColumn col = new DataColumn();
        dt2.Columns.Add("etunimi", typeof(string));
        dt2.Columns.Add("sukunimi", typeof(string));
        dt2.Columns.Add("numero", typeof(Int32));
        dt2.Columns.Add("tyosuhde", typeof(string));
        dt2.Columns.Add("palkka", typeof(Int32));

        // ladataan polku webconfigista
        String tyontekijatXml = ConfigurationManager.AppSettings["tyontekijat"];
        xdoc.Load(Server.MapPath(tyontekijatXml));


        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string tyosuhdeXML = node["tyosuhde"].InnerText;
            string maaraaikainen = "määräaikainen";
            if (maaraaikainen == tyosuhdeXML)
            {

                string etunimi = node["etunimi"].InnerText;
                string sukunimi = node["sukunimi"].InnerText;
                int numero = Convert.ToInt32(node["numero"].InnerText);
                string tyosuhde = node["tyosuhde"].InnerText;
                int palkka = Convert.ToInt32(node["palkka"].InnerText);

                dt2.Rows.Add(etunimi, sukunimi, numero, tyosuhde, palkka);
            }
        }



        GridView1.DataSource = dt2;
        GridView1.DataBind();


        object Kokonaispalkka;
        Kokonaispalkka = dt2.Compute("Sum(palkka)", "");
        int palkkaAll = Convert.ToInt32(Kokonaispalkka);

        Label1.Text = "Kokonaispalkka= " + palkkaAll.ToString();

        int tyontekijoita = dt2.Rows.Count;
        Label2.Text = "Yhteensä " + tyontekijoita.ToString() + "työntekijää";
    }

    private void LoadMuut()
    {
        DataTable dt3 = new DataTable();
        DataColumn col = new DataColumn();
        dt3.Columns.Add("etunimi", typeof(string));
        dt3.Columns.Add("sukunimi", typeof(string));
        dt3.Columns.Add("numero", typeof(Int32));
        dt3.Columns.Add("tyosuhde", typeof(string));
        dt3.Columns.Add("palkka", typeof(Int32));

        // ladataan polku webconfigista
        String tyontekijatXml = ConfigurationManager.AppSettings["tyontekijat"];
        xdoc.Load(Server.MapPath(tyontekijatXml));


        foreach (XmlNode node in xdoc.DocumentElement)
        {
            string tyosuhdeXML = node["tyosuhde"].InnerText;
            string muut = "muut";
            if (muut == tyosuhdeXML)
            {

                string etunimi = node["etunimi"].InnerText;
                string sukunimi = node["sukunimi"].InnerText;
                int numero = Convert.ToInt32(node["numero"].InnerText);
                string tyosuhde = node["tyosuhde"].InnerText;
                int palkka = Convert.ToInt32(node["palkka"].InnerText);

                dt3.Rows.Add(etunimi, sukunimi, numero, tyosuhde, palkka);
            }
        }



        GridView1.DataSource = dt3;
        GridView1.DataBind();

        
            object Kokonaispalkka;
            Kokonaispalkka = dt3.Compute("Sum(palkka)", "");

        // selvitä miten käsitellä virhe
        if (Kokonaispalkka != null)
        {
            int palkkaAll = Convert.ToInt32(Kokonaispalkka);

            Label1.Text = "Kokonaispalkka= " + palkkaAll.ToString();
        }

        int tyontekijoita = dt3.Rows.Count;
        Label2.Text = "Yhteensä " + tyontekijoita.ToString() + "työntekijää";
    }



    protected void btnVakituiset_Click(object sender, EventArgs e)
    {
        LoadVakituiset();
    }

    protected void btnMaaraaikaiset_Click(object sender, EventArgs e)
    {
        LoadMaaraaikaiset();
    }

    protected void btnMuut_Click(object sender, EventArgs e)
    {
        LoadMuut();
    }
}