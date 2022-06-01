using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using MyErp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;


namespace MyErp.Extensions{
    
public static class MyHtmlHelperExtensions {
    public static string[] getFilter(int _gridId)
        {
            string [] filter_column = new string [16];
            
            int _howmany=0;
            for (int _ncol =1;_ncol<=15;_ncol++)
            {
                filter_column[_ncol] = CookiesReturn( "_"+_gridId.ToString()+"-"+"filterby-"+_ncol.ToString(),false);    
                if (filter_column[_ncol]!=""){_howmany++;}
            }
            filter_column[0]=_howmany.ToString();
            return filter_column;
        }
    public static IEnumerable<Container> filterTableByColumn (IEnumerable<Container> oTMaterial,int _gridId)
        {
            string [] campos =getFilter(_gridId);
            var queryca = (from p in oTMaterial
                        where 
                        (p.Campo01.Contains(campos[1]) || campos[1]=="") &&
                        (p.Campo02.Contains(campos[2]) || campos[2]=="") &&
                        (p.Campo03.Contains(campos[3]) || campos[3]=="") &&
                        (p.Campo04.Contains(campos[4]) || campos[4]=="") &&
                        (p.Campo05.Contains(campos[5]) || campos[5]=="") &&
                        (p.Campo06.Contains(campos[6]) || campos[6]=="") &&
                        (p.Campo07.Contains(campos[7]) || campos[7]=="") &&
                        (p.Campo08.Contains(campos[8]) || campos[8]=="") &&
                        (p.Campo09.Contains(campos[9]) || campos[9]=="") &&
                        (p.Campo10.Contains(campos[10]) || campos[10]=="") &&
                        (p.Campo11.Contains(campos[11]) || campos[11]=="") &&
                        (p.Campo12.Contains(campos[12]) || campos[12]=="") &&
                        (p.Campo13.Contains(campos[13]) || campos[13]=="") &&
                        (p.Campo14.Contains(campos[14]) || campos[14]=="") &&
                        (p.Campo15.Contains(campos[15]) || campos[15]=="") 
                        select p).ToList();
            return (IEnumerable<Container>)queryca;
        }
    public static IEnumerable<Container> sortTableByColumn (IEnumerable<Container> oTMaterial,int col_orderton,int col_sortorder)
        {
            switch (col_orderton)
            {
                case 1:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo01);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo01);
                        }            
                    break;
                case 2:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo02);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo02);
                        }            
                    break;
                case 3:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo03);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo03);
                        }            
                    break;
                case 4:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo04);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo04);
                        }            
                    break;
                case 5:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo05);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo05);
                        }            
                    break;
                case 6:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo06);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo06);
                        }            
                    break;
                case 7:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo07);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo07);
                        }            
                    break;
                case 8:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo08);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo08);
                        }            
                    break;
                case 9:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo09);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo09);
                        }            
                    break;
                case 10:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo10);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo10);
                        }            
                    break;
                case 11:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo11);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo11);
                        }            
                    break;
                case 12:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo12);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo12);
                        }            
                    break;
                case 13:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo13);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo13);
                        }            
                    break;
                case 14:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo14);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo14);
                        }            
                    break;
                case 15:
                    if (col_sortorder==1)
                        {
                            oTMaterial = oTMaterial.OrderBy(x =>x.Campo15);
                        }
                    else 
                        {
                            oTMaterial = oTMaterial.OrderByDescending(x =>x.Campo15);
                        }            
                    break;
                default:
                    break;
            }
            return oTMaterial;
        }
    public static string CookiesReturn(string cookiename, bool isnum=true)
            {
                string cookievalue ="";
                try{
                IHttpContextAccessor _httpContextAccessor= new HttpContextAccessor(); 
                cookievalue = _httpContextAccessor.HttpContext.Request.Cookies[cookiename]; 
                }
                catch(Exception ex){
                    string mensaje = ex.Message;
                }
                if (cookievalue is null||cookievalue==""){
                    if (isnum){cookievalue="0";}
                    else{cookievalue="";}
                }
                return cookievalue;
            }
    public static void CookiesSet(string cookiename,string cookievalue)
            {
                //string cookievalue ="";
                try{
                IHttpContextAccessor _httpContextAccessor=new HttpContextAccessor(); 
                Microsoft.AspNetCore.Http.CookieOptions options = new CookieOptions(); //default path /
                _httpContextAccessor.HttpContext.Response.Cookies.Append(cookiename,cookievalue,options); 
                }
                catch(Exception ex){
                    string mensaje = ex.Message;
                }
            }
    public static string getFilterExpression(List<string> fields, int _gridId )
    {
        string ret = "";
        string [] campos =getFilter(_gridId);
        bool first = true;
        for (int i=1;i < fields.Count();i++)
        {
            if (campos[i]!="")
            {
                if (!first){ret+=" and ";}
                first = false;
                ret+=fields[i]+" like '%"+campos[i].TrimStart().TrimEnd()+"%' ";
            }
        }
        if (ret==""){ret=" 1=1" ;}
        return ret;
    }
    public static string getSortExpression(List<string> fields ,int col_orderton,int col_sortorder )
    {
        string ret =fields[col_orderton];
        if (col_orderton!=0){
            if (col_sortorder!=1){ret+=" DESC ";}
        }
        return ret;
        
    }
    public static IHtmlContent dataGrid(this IHtmlHelper htmlHelper,int Idgrid, int rowspage,List<string> cabText,IEnumerable<Container> _TMaterial,string [] contAction,List<string> fields, int _Id=0,string _parqs="",bool Senable=true,bool Fenable=true,string formid="",string model="") {
            string Tablemod=cabText[0];
            string uniqueId = Idgrid.ToString();//  getUid();
            int gridCount = Convert.ToInt32(CookiesReturn( "gridcount"));

            int curpag = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"currentpage"));    


            string quehayaqui=CookiesReturn("_1-filterby-2",false);

            if (Idgrid>gridCount){
                CookiesSet("gridcount",uniqueId);
            }
            string _controller=contAction[0];//cabText[0];
            string _actionEdit =contAction[1];//"MatEdit";
            string _actionCreate =contAction[2];//"MatEdit";
            string _actionDelete =contAction[3];//"MatEdit";
            int _ncols = cabText.Count-1;

            //string controlesgrid = Convert.ToString(CookiesReturn( uniqueId+"-"+"controlesgrid"));    

            int row_selected = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"rowselected"));    
            int pro_selected = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"proselected"));    
            int col_orderton = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"colorderton"));
            int col_sortorder = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"sortorder"));
            
            string[] filterData = getFilter(Idgrid);
            int _howmanycolumnselected = Convert.ToInt32(filterData[0]);
            int current_page = Convert.ToInt32(CookiesReturn( "_"+uniqueId+"-"+"currentpage")); 

            if (current_page==0){
                current_page =1;
                CookiesSet("_"+uniqueId+"-"+"currentpage","1");
            }   
            //int rid_selected = Convert.ToInt32(CookiesReturn( "ridselected"));    

            IEnumerable<Container>sTMaterial=sortTableByColumn(_TMaterial,col_orderton,col_sortorder);
            IEnumerable<Container>oTMaterial=filterTableByColumn(sTMaterial,Idgrid);

            string sortExpression=getSortExpression(fields,col_orderton,col_sortorder);
            string filterExpression=getFilterExpression(fields, Idgrid);
            CookiesSet("Grid-"+Tablemod,uniqueId);
            CookiesSet("Grid-"+uniqueId+"-"+"sortExpression",sortExpression.ToString());
            CookiesSet("Grid-"+uniqueId+"-"+"filterExpression",filterExpression.ToString());

            IEnumerable<Container> TMaterial=oTMaterial;

            var tagret = new TagBuilder ($"div");
            tagret.MergeAttribute("name","div-grid-return");
            tagret.Attributes.Add("class", $"absolute");

            var htagtab = new TagBuilder($"table"); //<able>
            htagtab.MergeAttribute("id","_"+uniqueId+"-"+"h-data-table");
            htagtab.MergeAttribute("hidden","hidden");

            var tagtab = new TagBuilder($"table"); //<able>
            tagtab.MergeAttribute("id","data-table");
            tagtab.MergeAttribute("name","div-grid-table");
            tagtab.MergeAttribute("style","width:100%");
            var tagtbtr = new TagBuilder($"tr"); //<able>
            var tagtbtd = new TagBuilder($"td"); //<able>
            tagtbtd.MergeAttribute("style","width:100%");

            var tagdiv = new TagBuilder ($"div");



            tagtab.Attributes.Add("class", $"table-norm");// table table-striped table-bordered");
            
            //<table id="assets-data-table" class="table table-striped table-bordered" style="width:100%">

            //tagdiv.Attributes.Add("class", $"_cont-titles");

            var tagdfo = new TagBuilder ($"div");
            tagdfo.Attributes.Add("class", $"foot-pager");
            tagdfo.MergeAttribute("name","div-grid-foot");

            /*
            var tagcab = new TagBuilder ($"h2");
            //tagcab.Attributes.Add("class", $"head-text");
            tagcab.InnerHtml.Append(cabText[0]);

            tagdiv.InnerHtml.AppendHtml(tagcab);
            */
            
            //tagtab.InnerHtml.AppendHtml(tagdiv);

            var tagdivx = new TagBuilder ($"div");
            tagdivx.Attributes.Add("class", $"_visible");
            /*
            //<label>Click me <input type="text" id="Name" name="Name" /></label>
            var taglab = new TagBuilder ($"label");
            taglab.InnerHtml.Append("Current Page");
            var tagtexp=new TagBuilder ($"input");
            tagtexp.Attributes.Add("class", $"norm-num");
            tagtexp.MergeAttribute("type","text");
            tagtexp.MergeAttribute("size","2");
            tagtexp.MergeAttribute("id","curpage");
            tagtexp.MergeAttribute("name","curpage");
            //tagtexp.MergeAttribute("value",current_page.ToString());
            */
            //button Create Record
            var tagbac = new TagBuilder ($"button");
            tagbac.Attributes.Add("class", $"dropbtn");
            tagbac.MergeAttribute("type","button");
            tagbac.MergeAttribute("name","btn_create");
            //tagbac.MergeAttribute("page",npage.ToString());
            tagbac.MergeAttribute("onclick","addRecord('"+_controller+"','"+_actionCreate+"',"+_Id.ToString()+",'"+formid+"')");
            tagbac.InnerHtml.Append("Create Record");
            tagdivx.InnerHtml.AppendHtml(tagbac);


            //button Export
            var tagbae = new TagBuilder ($"button");
            tagbae.Attributes.Add("class", $"dropbtn");
            tagbae.MergeAttribute("type","button");
            tagbae.MergeAttribute("name","btn_export");
            //tagbac.MergeAttribute("page",npage.ToString());
            tagbae.MergeAttribute("onclick","exportData("+_ncols.ToString()+",'"+uniqueId+"')");
            tagbae.InnerHtml.Append("Export Data");
            tagdivx.InnerHtml.AppendHtml(tagbae);


            var tagdivb1 = new TagBuilder ($"div");
            tagdivb1.Attributes.Add("class", $"dropdown");
            tagdivb1.MergeAttribute("id","_"+uniqueId+"-"+"dd_div_btn");
            //tagdivb1.Attributes.Add("class", $"invisible");

            // <input type="hidden" id="custId" name="custId" value="3487">
            var taghid = new TagBuilder ($"input");
            taghid.MergeAttribute("type", $"hidden");
            taghid.MergeAttribute("id","_"+uniqueId+"-"+"cntrl_id");
            taghid.MergeAttribute("name","_"+uniqueId+"-"+"cntrl_id");
            taghid.MergeAttribute("value",uniqueId.ToString());
            tagdivb1.InnerHtml.AppendHtml(taghid);

            var tagbdd = new TagBuilder ($"button");
            tagbdd.Attributes.Add("class", $"dropbtn");
            tagbdd.MergeAttribute("id","btn_dropdn");
            tagbdd.MergeAttribute("type","button");
            tagbdd.MergeAttribute("name","btn_dropdn");
            tagbdd.MergeAttribute("onclick","funcDropDown('"+uniqueId+"')");
            tagbdd.InnerHtml.Append("Acciones");
            tagdivb1.InnerHtml.AppendHtml(tagbdd);

            var tagdivb2 = new TagBuilder ($"div");
            tagdivb2.MergeAttribute("id","_"+uniqueId+"-"+"myDropdown");
            tagdivb2.Attributes.Add("class", $"dropdown-content");

            var tagac1 = new TagBuilder ($"a");
            //<a href=”javascript:JavaScript_Function()”>Click</a>
            tagac1.MergeAttribute("href","javascript:actionClick('"+_controller+"','"+_actionDelete+"','"+rowspage.ToString()+"','"+uniqueId+"','"+_parqs+"')");//+filterExpression+"','"+sortExpression+"')");
            tagac1.Attributes.Add("class", $"elements");
            tagac1.InnerHtml.Append("Delete");
            tagdivb2.InnerHtml.AppendHtml(tagac1);

            var tagac2 = new TagBuilder ($"a");
            tagac2.MergeAttribute("href","javascript:actionClick('"+_controller+"','"+_actionEdit+"','"+rowspage.ToString()+"','"+uniqueId+"','"+_parqs+"')");//+filterExpression+"','"+sortExpression+"')");
            //tagac2.MergeAttribute("href",_controller+"/"+_actionEdit+"/"+rid_selected.ToString());
            tagac2.Attributes.Add("class", $"elements");
            tagac2.InnerHtml.Append("Edit");
            tagdivb2.InnerHtml.AppendHtml(tagac2);

            tagdivb1.InnerHtml.AppendHtml(tagdivb2);
            tagdivx.InnerHtml.AppendHtml(tagdivb1);

            tagtab.InnerHtml.AppendHtml(tagdivx);
            //htagtab.InnerHtml.AppendHtml(tagdivx);


            var tagtrc = new TagBuilder($"tr"); 
            var tagtrhc = new TagBuilder($"tr"); 
            

            int pcsel=6; //porcentaje ancho columna select
            string Pcsel=pcsel.ToString()+"%";
            int pct=Convert.ToInt32(Decimal.Truncate((100-pcsel)/(_ncols)));
            string Pct =pct.ToString()+"%";


            var tagthc0 = new TagBuilder($"th"); 
            tagthc0.Attributes.Add("class", $"head-text");
            tagthc0.InnerHtml.Append("Select "+uniqueId);
            tagthc0.Attributes.Add("width", Pcsel);
            tagtrc.InnerHtml.AppendHtml(tagthc0);
            for (int i=1;i<=_ncols;i++)
            {
                var tagthc_ = new TagBuilder($"th"); 
                tagthc_.Attributes.Add("class", $"head-text");
                tagthc_.Attributes.Add("width", Pct);
                if (Senable){tagthc_.MergeAttribute("onclick","sortTable("+i.ToString().Trim()+",'"+uniqueId+"')");}
                tagthc_.InnerHtml.Append(cabText[i]);
                tagtrc.InnerHtml.AppendHtml(tagthc_);
                tagtrhc.InnerHtml.AppendHtml(tagthc_);

            }
/*
            if (_ncols>=1){
                var tagthc1 = new TagBuilder($"th"); 
                tagthc1.Attributes.Add("class", $"head-text");
                tagthc1.MergeAttribute("onclick","sortTable(1,'"+uniqueId+"')");
                tagthc1.InnerHtml.Append(cabText[1]);
                tagtrc.InnerHtml.AppendHtml(tagthc1);
                tagtrhc.InnerHtml.AppendHtml(tagthc1);
            }
            if (_ncols>=2){
                var tagthc2 = new TagBuilder($"th"); 
                tagthc2.Attributes.Add("class", $"head-text");
                tagthc2.MergeAttribute("onclick","sortTable(2,'"+uniqueId+"')");
                tagthc2.InnerHtml.Append(cabText[2]);
                tagtrc.InnerHtml.AppendHtml(tagthc2);
                tagtrhc.InnerHtml.AppendHtml(tagthc2);
            }
            if (_ncols>=3){
                var tagthc3 = new TagBuilder($"th"); 
                tagthc3.Attributes.Add("class", $"head-text");
                tagthc3.MergeAttribute("onclick","sortTable(3,'"+uniqueId+"')");
                tagthc3.InnerHtml.Append(cabText[3]);
                tagtrc.InnerHtml.AppendHtml(tagthc3);
                tagtrhc.InnerHtml.AppendHtml(tagthc3);
            }
            if (_ncols >= 4){
                var tagthc4 = new TagBuilder($"th"); 
                tagthc4.Attributes.Add("class", $"head-text");
                tagthc4.MergeAttribute("onclick","sortTable(4,'"+uniqueId+"')");
                tagthc4.InnerHtml.Append(cabText[4]);
                tagtrc.InnerHtml.AppendHtml(tagthc4);
                tagtrhc.InnerHtml.AppendHtml(tagthc4);
            }
            if (_ncols>=5){
                var tagthc5 = new TagBuilder($"th"); 
                tagthc5.Attributes.Add("class", $"head-text");
                tagthc5.MergeAttribute("onclick","sortTable(5,'"+uniqueId+"')");
                tagthc5.InnerHtml.Append(cabText[5]);
                tagtrc.InnerHtml.AppendHtml(tagthc5);
                tagtrhc.InnerHtml.AppendHtml(tagthc5);
            }
*/
            tagtab.InnerHtml.AppendHtml(tagtrc);
            htagtab.InnerHtml.AppendHtml(tagtrhc);

            /*Encabezado para buscar y filtrar
            
            var tagdivf = new TagBuilder ($"div");
            tagdivf.MergeAttribute("id","_"+uniqueId+"-"+"myFilter");
            tagdivf.Attributes.Add("class", $"visible");
            //tagdivf.Attributes.Add("class", $"dropdown-content");
            */
            var tagtrf = new TagBuilder($"tr"); 
            
            //<input type="text" id="fname" name="fname">
            var tagtf0 = new TagBuilder($"th"); 
            tagtf0.Attributes.Add("width", Pcsel);
            tagtf0.Attributes.Add("class", $"head-text");
            tagtf0.InnerHtml.Append("Filter ");
            tagtrf.InnerHtml.AppendHtml(tagtf0);

            for (int i=1;i<=_ncols;i++)
            {
                var tagtf_ = new TagBuilder($"th"); 
                //tagtf_.Attributes.Add("width", Pct);
                var tagtexf_ = new TagBuilder($"input"); 
                tagtexf_.Attributes.Add("class", $"searchtb");
                //tagtexf_.Attributes.Add("style", "width:"+Pct.ToString()+"%");

                tagtexf_.MergeAttribute("type", $"text");
                tagtexf_.MergeAttribute("id","_"+uniqueId+"-"+"filter-"+i.ToString().Trim());
                tagtexf_.MergeAttribute("name","_"+uniqueId+"-"+"filter-"+i.ToString().Trim());
                tagtexf_.MergeAttribute("onchange","filterTable("+i.ToString().Trim()+",'"+uniqueId+"')");
                tagtexf_.MergeAttribute("value", filterData[i]);
                tagtf_.InnerHtml.AppendHtml(tagtexf_);
                tagtrf.InnerHtml.AppendHtml(tagtf_);

            }

/*
            if (_ncols>=1){
                var tagtf1 = new TagBuilder($"th"); 
                var tagtexf1 = new TagBuilder($"input"); 
                tagtexf1.MergeAttribute("type", $"text");
                tagtexf1.MergeAttribute("id","_"+uniqueId+"-"+"filter-1");
                tagtexf1.MergeAttribute("name","_"+uniqueId+"-"+"filter-1");
                tagtexf1.MergeAttribute("onchange","filterTable(1,'"+uniqueId+"')");
                tagtexf1.MergeAttribute("value", filterData[1]);
                tagtf1.InnerHtml.AppendHtml(tagtexf1);
                tagtrf.InnerHtml.AppendHtml(tagtf1);
            }
            if (_ncols>=2){
                var tagtf2 = new TagBuilder($"th"); 
                var tagtexf2 = new TagBuilder($"input"); 
                tagtexf2.MergeAttribute("type", $"text");
                tagtexf2.MergeAttribute("id","_"+uniqueId+"-"+"filter-2");
                tagtexf2.MergeAttribute("name","_"+uniqueId+"-"+"filter-2");
                tagtexf2.MergeAttribute("onchange","filterTable(2,'"+uniqueId+"')");
                tagtexf2.MergeAttribute("value", filterData[2]);
                tagtf2.InnerHtml.AppendHtml(tagtexf2);
                tagtrf.InnerHtml.AppendHtml(tagtf2);
            }
            if (_ncols>=3){
                var tagtf3 = new TagBuilder($"th"); 
                var tagtexf3 = new TagBuilder($"input"); 
                tagtexf3.MergeAttribute("type", $"text");
                tagtexf3.MergeAttribute("id","_"+uniqueId+"-"+"filter-3");
                tagtexf3.MergeAttribute("name","_"+uniqueId+"-"+"filter-3");
                tagtexf3.MergeAttribute("onchange","filterTable(3,'"+uniqueId+"')");
                tagtexf3.MergeAttribute("value", filterData[3]);
                tagtf3.InnerHtml.AppendHtml(tagtexf3);
                tagtrf.InnerHtml.AppendHtml(tagtf3);
            }
            if (_ncols >= 4){
                var tagtf4 = new TagBuilder($"th"); 
                var tagtexf4 = new TagBuilder($"input"); 
                tagtexf4.MergeAttribute("type", $"text");
                tagtexf4.MergeAttribute("id","_"+uniqueId+"-"+"filter-4");
                tagtexf4.MergeAttribute("name","_"+uniqueId+"-"+"filter-4");
                tagtexf4.MergeAttribute("onchange","filterTable(4,'"+uniqueId+"')");
                tagtexf4.MergeAttribute("value", filterData[4]);
                tagtf4.InnerHtml.AppendHtml(tagtexf4);
                tagtrf.InnerHtml.AppendHtml(tagtf4);
            }
            if (_ncols>=5){
                var tagtf5 = new TagBuilder($"th"); 
                var tagtexf5 = new TagBuilder($"input"); 
                tagtexf5.MergeAttribute("type", $"text");
                tagtexf5.MergeAttribute("id","_"+uniqueId+"-"+"filter-5");
                tagtexf5.MergeAttribute("name","_"+uniqueId+"-"+"filter-5");
                tagtexf5.MergeAttribute("onchange","filterTable(5,'"+uniqueId+"')");
                tagtexf5.MergeAttribute("value", filterData[5]);
                tagtf5.InnerHtml.AppendHtml(tagtexf5);
                tagtrf.InnerHtml.AppendHtml(tagtf5);
            }
*/
            //tagtrf.InnerHtml.AppendHtml(tagdivf);
            if (Fenable){tagtab.InnerHtml.AppendHtml(tagtrf);}
            //htagtab.InnerHtml.AppendHtml(tagtrf);

            /*
            <table class="table-norm" border="1">
            <div class="cont-titles">
            <h2>Product Data</h2>
            </div>
            <tr>
                <th class="head-text">Referencia</th> 
                <th class="head-text">Descripcion</th> 
                <th class="head-text">Fecha Creacion</th>                
                <th class="head-text">Status</th>        
                <th class="head-text">Fecha Status</th>        
            </tr>

            */
            bool hiddenphase =false;
            int tcount=1;
            int nrow=1;
            //int rowspage=7;
            int npage =1;
            int numpages = TMaterial.Count()/rowspage;
            const string quote = "\"";  
            if (!(TMaterial.Count()%rowspage==0)){numpages ++;}
            foreach (var c in TMaterial) {
                if (npage ==current_page)
                {
                    insert_row( 1,_ncols,Pct,c,tagtab,nrow,uniqueId, row_selected,pro_selected,current_page,rowspage,_controller, _actionEdit,model);
                    insert_row( 0,_ncols,Pct,c,htagtab,nrow,uniqueId, row_selected,pro_selected,current_page,rowspage,_controller, _actionEdit);
                    nrow++;   
                    if (nrow>rowspage)
                    {
                        hiddenphase=true;
                        addBtnFoot(tagdfo,npage,numpages,uniqueId);
                        //nrow=1;
                        npage ++;
                        //break;
                    }      
                }
                else{
                    insert_row( 0,_ncols,Pct,c,htagtab,nrow,uniqueId, row_selected,pro_selected,current_page,rowspage,_controller, _actionEdit);
                    tcount++;
                    nrow++;   
                    if (nrow>rowspage)
                    {
                        nrow=1;
                        npage ++;
                    }
                }    
            }
            if (!hiddenphase)
            {
                bool addfoot=false;
                while  (nrow<=rowspage)
                    {
                        addfoot =true;
                        insert_row_void(nrow,_ncols,Pct,tagtab);
                        nrow ++;
                    }
                if (addfoot)
                {
                
                    addBtnFoot(tagdfo,npage,numpages,uniqueId);
                }
            }
            tagtbtd.InnerHtml.AppendHtml(htagtab);
            tagtbtd.InnerHtml.AppendHtml(tagtab);
            tagtbtd.InnerHtml.AppendHtml(tagdfo);
            tagtbtr.InnerHtml.AppendHtml(tagtbtd);

            tagret.InnerHtml.AppendHtml(tagtbtr);

            return tagret;
        }
    public static void insert_row_void(int nrow, int _ncols, string Pct,TagBuilder tagtab)
    {
                    var tagtr = new TagBuilder($"tr"); //<tr>
                    if (nrow%2==0 )
                    {   tagtr.Attributes.Add("class", $"line-text-pri");}
                    else{tagtr.Attributes.Add("class", $"line-text-alt");}

                    for (int i=0;i<=_ncols;i++)  //starts with 0 to include check column
                    {
                        var tagtd_ = new TagBuilder($"td"); //<tr>
                        if (i!=0){tagtd_.Attributes.Add("width", Pct);}
                        tagtd_.InnerHtml.Append("" );
                        tagtr.InnerHtml.AppendHtml(tagtd_);
                    }
/*
                    var tagtd0 = new TagBuilder($"td"); //<tr>
                    tagtd0.InnerHtml.Append("" );
                    tagtr.InnerHtml.AppendHtml(tagtd0);

                    var tagtd1 = new TagBuilder($"td"); //<tr>
                    tagtd1.InnerHtml.Append("" );
                    tagtr.InnerHtml.AppendHtml(tagtd1);

                    var tagtd2 = new TagBuilder($"td"); //<tr>
                    tagtd2.InnerHtml.Append("");
                    tagtr.InnerHtml.AppendHtml(tagtd2);
            
                    var tagtd3 = new TagBuilder($"td"); //<tr>
                    tagtd3.InnerHtml.Append("");
                    tagtr.InnerHtml.AppendHtml(tagtd3);

                    var tagtd4 = new TagBuilder($"td"); //<tr>
                    tagtd4.InnerHtml.Append("");
                    tagtr.InnerHtml.AppendHtml(tagtd4);

                    var tagtd5 = new TagBuilder($"td"); //<tr>
                    tagtd5.InnerHtml.Append("");
                    tagtr.InnerHtml.AppendHtml(tagtd5);
*/
                    tagtab.InnerHtml.AppendHtml(tagtr);  

    }
    public static void insert_row(int pri,int _ncols, string Pct, Container c,TagBuilder tagtab,int nrow,string uniqueId,int row_selected,int pro_selected,int current_page,int rowspage,string _controller, string _actionEdit,string model="")
    {
                    var tagtr = new TagBuilder($"tr"); //<tr>
                    if (pri==1){
                    tagtr.MergeAttribute("id","_"+uniqueId+"-"+"trRow"+nrow.ToString().Trim());
                    if (nrow ==row_selected && pro_selected==current_page)
                        {tagtr.Attributes.Add("class", $"line-text-sel");}
                    else{
                        if (nrow%2==0 )
                        {   tagtr.Attributes.Add("class", $"line-text-pri");}
                        else{
                            tagtr.Attributes.Add("class", $"line-text-alt");}
                    }
                    }

                    if (pri==1){
                    var tagtd0 = new TagBuilder($"td"); //<tr>
                    var tagcbx = new TagBuilder($"input"); //<tr>
                    tagcbx.MergeAttribute("type","checkbox");
                    tagcbx.MergeAttribute("id","_"+uniqueId+ "-"+nrow.ToString());
                    tagcbx.MergeAttribute("value",c.CampoId.ToString());
                    tagcbx.MergeAttribute("onclick","selectionchange("+nrow.ToString()+","+rowspage.ToString()+",'"+uniqueId+"')");
                    tagcbx.Attributes.Add("width", Pct);
                    tagtd0.InnerHtml.AppendHtml(tagcbx);
                    tagtr.InnerHtml.AppendHtml(tagtd0);
                    }
                    //tagtdx.MergeAttribute("onclick","rowClick()");


                    for (int i=1;i<=_ncols;i++)
                    {
                        var tagtd_ = new TagBuilder($"td"); //<tr>
                        //tagtd_.Attributes.Add("class", $"with_auto");
                        tagtd_.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"','"+model.ToString()+"')");//,"+quote+filterExpression+quote +",'"+sortExpression+"')");
                        tagtd_.Attributes.Add("width", Pct);
                        switch(i)
                        {
                            case 1:
                                tagtd_.InnerHtml.Append(c.Campo01 );
                                break;
                            case 2:
                                tagtd_.InnerHtml.Append(c.Campo02 );
                                break;
                            case 3:
                                tagtd_.InnerHtml.Append(c.Campo03 );
                                break;
                            case 4:
                                tagtd_.InnerHtml.Append(c.Campo04 );
                                break;
                            case 5:
                                tagtd_.InnerHtml.Append(c.Campo05 );
                                break;
                            case 6:
                                tagtd_.InnerHtml.Append(c.Campo06 );
                                break;
                            case 7:
                                tagtd_.InnerHtml.Append(c.Campo07 );
                                break;
                            case 8:
                                tagtd_.InnerHtml.Append(c.Campo08 );
                                break;
                            case 9:
                                tagtd_.InnerHtml.Append(c.Campo09 );
                                break;
                            case 10:
                                tagtd_.InnerHtml.Append(c.Campo10 );
                                break;
                            case 11:
                                tagtd_.InnerHtml.Append(c.Campo11 );
                                break;
                            case 12:
                                tagtd_.InnerHtml.Append(c.Campo12 );
                                break;
                            case 13:
                                tagtd_.InnerHtml.Append(c.Campo13 );
                                break;
                            case 14:
                                tagtd_.InnerHtml.Append(c.Campo14 );
                                break;
                            case 15:
                                tagtd_.InnerHtml.Append(c.Campo15 );
                                break;
                            default:
                                tagtd_.InnerHtml.Append("" );
                                break;
                        }
                        tagtr.InnerHtml.AppendHtml(tagtd_);
                    }
/*
                    var tagtd1 = new TagBuilder($"td"); //<tr>
                    tagtd1.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"')");//,"+quote+filterExpression+quote +",'"+sortExpression+"')");
                    tagtd1.InnerHtml.Append(c.Campo01 );
                    tagtr.InnerHtml.AppendHtml(tagtd1);

                    var tagtd2 = new TagBuilder($"td"); //<tr>
                    tagtd2.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"')");//,"+quote+filterExpression+quote+",'"+sortExpression+"')");
                    tagtd2.InnerHtml.Append(c.Campo02);
                    tagtr.InnerHtml.AppendHtml(tagtd2);
            
                    var tagtd3 = new TagBuilder($"td"); //<tr>
                    tagtd3.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"')");//,"+quote+filterExpression+quote+",'"+sortExpression+"')");
                    tagtd3.InnerHtml.Append(c.Campo03);
                    tagtr.InnerHtml.AppendHtml(tagtd3);

                    var tagtd4 = new TagBuilder($"td"); //<tr>
                    tagtd4.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"')");//,"+quote+filterExpression+quote+",'"+sortExpression+"')");
                    tagtd4.InnerHtml.Append(c.Campo04);
                    tagtr.InnerHtml.AppendHtml(tagtd4);

                    var tagtd5 = new TagBuilder($"td"); //<tr>
                    tagtd5.MergeAttribute("onclick","rowClick("+nrow.ToString()+",'"+_controller+"','"+_actionEdit+"','"+uniqueId+"')");//,"+quote+filterExpression+quote+",'"+sortExpression+"')");
                    tagtd5.InnerHtml.Append(c.Campo05);
                    tagtr.InnerHtml.AppendHtml(tagtd5);
*/

                    tagtab.InnerHtml.AppendHtml(tagtr);  

    }
    public static void addBtnFoot (TagBuilder tagdfo, int npage, int numpages,string uniqueId)
        {
                        var taglfo = new TagBuilder ($"label");
                        taglfo.Attributes.Add("class", $"dropbtn");
                        //taglfo.InnerHtml.Append("Page ");
                        taglfo.InnerHtml.Append("Page "+npage.ToString()+" of "+numpages.ToString());
                        tagdfo.InnerHtml.AppendHtml(taglfo);
                        if (npage >1)
                        {
                            var tagdf1 = new TagBuilder ($"button");
                            tagdf1.Attributes.Add("class", $"dropbtn");
                            tagdf1.MergeAttribute("type","button");
                            tagdf1.MergeAttribute("name","btn_prev");
                            tagdf1.MergeAttribute("page",npage.ToString());
                            tagdf1.MergeAttribute("onclick","prevPage("+npage.ToString()+",'"+uniqueId+"')");
                            tagdf1.InnerHtml.Append("Prev");
                            tagdfo.InnerHtml.AppendHtml(tagdf1);
                        }
                        if (npage< numpages)
                        {
                            var tagdf2 = new TagBuilder ($"button");
                            tagdf2.Attributes.Add("class", $"dropbtn");
                            tagdf2.MergeAttribute("type","button");
                            tagdf2.MergeAttribute("name","btn_next");
                            tagdf2.MergeAttribute("npages",numpages.ToString());
                            tagdf2.MergeAttribute("onclick","nextPage("+npage.ToString()+","+numpages.ToString()+",'"+uniqueId+"')");
                            tagdf2.InnerHtml.Append("Next");
                            tagdfo.InnerHtml.AppendHtml(tagdf2);
                        }
                            //<input type="text" id="lname" name="lname">
                            var tagtex = new TagBuilder ($"input");
                            tagtex.Attributes.Add("class", $"norm-num");
                            tagtex.MergeAttribute("type","text");
                            tagtex.MergeAttribute("size","2");
                            tagtex.MergeAttribute("id","_"+uniqueId+ "-"+"newpage");
                            tagtex.MergeAttribute("name","_"+uniqueId+"-"+"newpage");
                            tagtex.MergeAttribute("placeholder","# Page to gor");
                            //tagtex.MergeAttribute("value",numpages.ToString());
                            tagdfo.InnerHtml.AppendHtml(tagtex);

                            var tagdf3 = new TagBuilder ($"button");
                            tagdf3.Attributes.Add("class", $"dropbtn");
                            tagdf3.MergeAttribute("type","button");
                            tagdf3.MergeAttribute("name","btn_goto");
                            tagdf3.MergeAttribute("onclick","gotoPage("+npage.ToString()+","+numpages.ToString()+",'"+uniqueId+"')");
                            tagdf3.InnerHtml.Append("GoTo");
                            tagdfo.InnerHtml.AppendHtml(tagdf3);

                            //var tagden = new TagBuilder ($"p");
                            //tagden.MergeAttribute("id","demo");
                            //tagdfo.InnerHtml.AppendHtml(tagden);
        }
    }
}