using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtavat_G2968_T1_G2968_Tehtava1c : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs ex)
    {
        if (!IsPostBack)
        {
            Label1.Text = "a";
            Label2.Text = "b";
            Label3.Text = "c";
            Label4.Text = "d";
            Label5.Text = "e";
            Label6.Text = "f";
            Label7.Text = "g";
            Label8.Text = "h";
            Label9.Text = "i";
            Label10.Text = "j";
            Label11.Text = "k";
            Label12.Text = "l";
            Label13.Text = "m";
            Label14.Text = "n";
            Label15.Text = "o";
            Label16.Text = "p";
            Label17.Text = "q";
            Label18.Text = "r";
            Label19.Text = "s";
            Label20.Text = "t";
            Label21.Text = "u";
            Label22.Text = "v";
            Label23.Text = "w";
            Label24.Text = "x";
            Label25.Text = "y";
            Label26.Text = "z";
            Label27.Text = "å";
            Label28.Text = "ä";
            Label29.Text = "ö";

            lblTotalCharCount.Text = "Total char count=Ei syötettyjä merkkejä";
            lblCharCountWithoutWhitespace.Text = "Char count = ei syötettyjä merkkejä";

        }

    }

    protected void Button1_Click(object sender, EventArgs ex)
    {
        String strInput = TextBox1.Text;

        


        int a1 = 0;
        int b1 = 0;
        int c1 = 0;
        int d1 = 0;
        int e1 = 0;
        int f1 = 0;
        int g1 = 0;
        int h1 = 0;
        int i1 = 0;
        int j1 = 0;
        int k1 = 0;
        int l1 = 0;
        int m1 = 0;
        int n1 = 0;
        int o1 = 0;
        int p1 = 0;
        int q1 = 0;
        int r1 = 0;
        int s1 = 0;
        int t1 = 0;
        int u1 = 0;
        int v1 = 0;
        int w1 = 0;
        int x1 = 0;
        int y1 = 0;
        int z1 = 0;
        int å1 = 0;
        int ä1 = 0;
        int ö1 = 0;


        // jaa eipäs meekkään näin olisi pitänyt verrata loopissa jos char x on a niin a++
        foreach (char a in strInput)
        {
            a1++;
        }
        foreach (char b in strInput)
        {
            b1++;
        }
        foreach (char c in strInput)
        {
            c1++;
        }
        foreach (char d in strInput)
        {
            d1++;
        }
        foreach (char e in strInput)
        {
            e1++;
        }
        foreach (char f in strInput)
        {
            f1++;
        }
        foreach (char g in strInput)
        {
            g1++;
        }
        foreach (char h in strInput)
        {
            h1++;
        }
        foreach (char i in strInput)
        {
            i1++;
        }
        foreach (char j in strInput)
        {
            j1++;
        }
        foreach (char k in strInput)
        {
            k1++;
        }
        foreach (char l in strInput)
        {
            l1++;
        }
        foreach (char m in strInput)
        {
            m1++;
        }
        foreach (char n in strInput)
        {
            n1++;
        }
        foreach (char o in strInput)
        {
            o1++;
        }
        foreach (char p in strInput)
        {
            p1++;
        }
        foreach (char q in strInput)
        {
            q1++;
        }
        foreach (char r in strInput)
        {
            r1++;
        }
        foreach (char s in strInput)
        {
            s1++;
        }
        foreach (char t in strInput)
        {
            t1++;
        }
        foreach (char u in strInput)
        {
            u1++;
        }
        foreach (char v in strInput)
        {
            v1++;
        }
        foreach (char w in strInput)
        {
            w1++;
        }
        foreach (char x in strInput)
        {
            x1++;
        }
        foreach (char y in strInput)
        {
            y1++;
        }
        foreach (char z in strInput)
        {
            z1++;
        }
        foreach (char å in strInput)
        {
            å1++;
        }
        foreach (char ä in strInput)
        {
            ä1++;
        }
        foreach (char ö in strInput)
        {
            ö1++;
        }


        long chartotal = CountTotalChars(strInput);
        long charWithoutWhitespace = CountCharsWithoutWhitespace(strInput);

        lblTotalCharCount.Text = chartotal.ToString();
        lblCharCountWithoutWhitespace.Text = charWithoutWhitespace.ToString();

        Label1.Text = a1.ToString();
        Label2.Text = b1.ToString();
        Label3.Text = c1.ToString();
        Label4.Text = d1.ToString();
        Label5.Text = e1.ToString();
        Label6.Text = f1.ToString();
        Label7.Text = g1.ToString();
        Label8.Text = h1.ToString();
        Label9.Text = i1.ToString();
        Label10.Text = j1.ToString();
        Label11.Text = k1.ToString();
        Label12.Text = l1.ToString();
        Label13.Text = m1.ToString();
        Label14.Text = n1.ToString();
        Label15.Text = o1.ToString();
        Label16.Text = p1.ToString();
        Label17.Text = q1.ToString();
        Label18.Text = r1.ToString();
        Label19.Text = s1.ToString();
        Label20.Text = t1.ToString();
        Label21.Text = u1.ToString();
        Label22.Text = v1.ToString();
        Label23.Text = w1.ToString();
        Label24.Text = x1.ToString();
        Label25.Text = y1.ToString();
        Label26.Text = z1.ToString();
        Label27.Text = å1.ToString();
        Label28.Text = ä1.ToString();
        Label29.Text = ö1.ToString();
       

    }
private long CountTotalChars(string strInput)
    {
        long intCount = 0;

        foreach (char ch in strInput)
        {
            intCount++;
        }
        return intCount;
    }

    private long CountCharsWithoutWhitespace(string strInput)
    {
        long intCount = 0;

        foreach (char ch in strInput)
        {
            if (!char.IsWhiteSpace(ch))
                intCount++;

        }
        return intCount;
    }







}