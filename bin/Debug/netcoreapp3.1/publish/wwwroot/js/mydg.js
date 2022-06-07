function funcDropDown(_gridId)
{
    document.getElementById(nameOf("myDropdown",_gridId)).classList.toggle("show");

}
function addRecord(controller,action,_Id=0,formid="",_parqs="")
{
    const querystring = window.location.search;
    const params = new URLSearchParams(querystring);
    if (action!=""){
        if (_parqs==""){
            var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"?Pid="+_Id.toString();
            url2=url2+"&"+params.toString();
            window.location.href = url2;
            }
        else{
            var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"?Pid="+_Id.toString()+"&"+_parqs;
            url2=url2+"&"+params.toString();
            window.location.href = url2;
        }
    }
    else{
        var url=window.location.href;
        window.location.href = url;
    }
    
}
function rowSelected(_mxrow,_gridId)
{
    var _nrsel=0;
    var _maxrows = parseInt(_mxrow);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
            try{
            ckBox=document.getElementById(nameOf(_nri.toString().trim(),_gridId));
            if (ckBox.checked){
                _nrsel=_nri;
                break; }
            }
            catch{break;}
    }
    return _nrsel;
}
function erowSelected(_mxrow,_gridId)
{
    var _nrsel=0;
    var _maxrows = parseInt(_mxrow);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
            try{
            ckBox=document.getElementById(nameOf(_nri.toString().trim(),"e"+_gridId));
            if (ckBox.checked){
                _nrsel=_nri;
                break; }
            }
            catch{break;}
    }
    return _nrsel;
}
function actionClick(controller,action,_maxrow,_gridId, _parqs="")//,filterExpression,sortExpression)
{
    const querystring = window.location.search;
    const params = new URLSearchParams(querystring);
    var retCont=getController()[0];
    var retAct=getController()[1];
    var _rparqs=encodeURIComponent(params)
    //alert (retCont+" "+controller);
    //alert (retAct+" "+action);
    if (action!=""){
    var _nrsel=0;
    _nrsel = parseInt(rowSelected(_maxrow,_gridId));
    if (_nrsel>0)
    {
        var checkbox = document.getElementById(nameOf(_nrsel.toString(),_gridId));
        checkbox.checked=false;
        document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
        document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";
        //var div = document.getElementById(nameOf('dd_div_btn',_gridId));
        //div.style.visibility = 'hidden';
        _id = checkbox.value.toString();
        if (_parqs==""){
            var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id;//+"?panel=1";//&sortExpression="+sortExpression.toString()+"&filterExpression="+filterExpression.toString()+"&IdGrid="+_gridId.toString();
            if (retCont==controller){
                url2=url2+"?"+params.toString();
            }
            else{
                url2=url2+"?"+params.toString()+"&retCont="+retCont+"&retAct="+retAct+"&_parqs="+_rparqs;
            }
            window.location.href = url2;
        }
        else{
            var url3=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id+"?"+_parqs+_id;
            if (retCont==controller){
                url3=url3+"&"+params.toString();
            }
            else{
                url3=url3+"&"+params.toString()+"&retCont="+retCont+"&retAct="+retAct+"&_parqs="+_rparqs;
            }
            window.location.href = url3;
        }
    }
    }
    else{
        var url=window.location.href;
        window.location.href = url;
    }
}
function getController(path=window.location.pathname)
{
    //var path=window.location.pathname;
    var abc=path.split("/");
    var controller=abc[1];
    var action=abc[2] || "index";
    var ret = [controller,action];
    return ret;
}
function getParams (url = window.location) {

	// Create a params object
	let params = {};

	new URL(url).searchParams.forEach(function (val, key) {
		if (params[key] !== undefined) {
			if (!Array.isArray(params[key])) {
				params[key] = [params[key]];
			}
			params[key].push(val);
		} else {
			params[key] = val;
		}
	});

	return params;

}
function updateTable(controller,action,_maxrow,field,_ncol,_gridId,new_value,_parqs)
{
    //document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";
    const querystring = window.location.search;
    const params = new URLSearchParams(querystring);
    //var purl=window.location.href;
    var retCont=getController()[0];
    var retAct=getController()[1];
    var _parqs=encodeURIComponent(params)
    var _nrsel=0;
    _nrsel = parseInt(rowSelected(_maxrow,_gridId));

    document.cookie = cookieName("ineditionmode-"+_nrsel.toString().trim(),_gridId)+"=1"+";path=/";
    //var _value = document.getElementById(nameOf(_nrsel.toString().trim()+'-value-'+_ncol.toString(),_gridId)).value;
    //var _texttofilter = document.getElementById(nameOf(_nrsel.toString().trim()+'-value-'+_ncol.toString(),_gridId)).value;
    //alert(_value);
    //alert(_texttofilter);
    
    //22-06-07 intentamos que  no cierre la edicion al volver de actualizar
    //desactivamos la linea de abajo
    //editLine(_maxrow,_gridId,0);

    if (action!=""){
    if (_nrsel>0)
    {
        //22-06-07 intentamos que  no cierre la edicion al volver de actualizar
        //desactivamos las 4 lineas de abajo
        var checkbox = document.getElementById(nameOf(_nrsel.toString(),_gridId));
        //checkbox.checked=false;
        //document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
        //document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";
        
        _id = checkbox.value.toString();
        if (_parqs==""){  //never
            //alert("con parametros");
            var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id;//+"?panel=1";//&sortExpression="+sortExpression.toString()+"&filterExpression="+filterExpression.toString()+"&IdGrid="+_gridId.toString();
            url2=url2+"?updField="+field+"&updValue="+new_value+"&"+params.toString()+"&retCont="+retCont+"&retAct="+retAct;
            //alert(url2);
            window.location.href = url2;
        }
        else{
            //alert("sin parametros");
            var url3=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id+"?"+_parqs+_id;
            url3=url3+"&updField="+field+"&updValue="+new_value+"&"+params.toString()+"&retCont="+retCont+"&retAct="+retAct+"&_parqs="+_parqs;
            //alert(url3);
            window.location.href = url3;
        }
    }
    }
    else{
        var url=window.location.href;
        window.location.href = url;
    }
}
function editLine(_maxrow,_gridId,_activate)//,filterExpression,sortExpression)
{
    var activate = parseInt(_activate);
    var _nrsel=0;
    _nrsel = parseInt(rowSelected(_maxrow,_gridId)); //La selecccion se produce en (f)
    if (_nrsel>0)
    {
        var divf = document.getElementById(nameOf('dd_div_cof',_gridId+"-"+_nrsel.toString().trim()));
        var dive = document.getElementById(nameOf('dd_div_coe',_gridId+"-"+_nrsel.toString().trim()));
        if (activate ==1){
            document.cookie = cookieName("ineditionmode-"+_nrsel.toString().trim(),_gridId)+"=1"+";path=/";
            divf.hidden=true;//.setAttribute("hidden", "hidden");;//divf.style.visibility = 'hidden';
            dive.hidden=false;//.removeAttribute("hidden"); //dive.style.visibility = 'visible';
        }
        else{
            document.cookie = cookieName("ineditionmode-"+_nrsel.toString().trim(),_gridId)+"=0"+";path=/";
            dive.hidden=true;//.setAttribute("hidden", "hidden");;//divf.style.visibility = 'hidden';
            divf.hidden=false;//.removeAttribute("hidden"); //dive.style.visibility = 'visible';
        }
    }
    //return;
}
function rowClick(_nr,controller,action,_gridId,model="")//,filterExpression,sortExpression)
{
    const querystring = window.location.search;
    const params = new URLSearchParams(querystring);
    var retCont=getController()[0];
    var retAct=getController()[1];
    var _rparqs=encodeURIComponent(params)
   if (action!=""){
    var _nrow = parseInt(_nr);
    var checkbox = document.getElementById(nameOf(_nr.toString(),_gridId));
    _id = checkbox.value.toString();
    if (model==""){
        var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id;//+"?panel=1";//&sortExpression="+sortExpression.toString()+"&filterExpression="+filterExpression.toString()+"&IdGrid="+_gridId.toString();
        if (retCont==controller){
            url2=url2+"?"+params.toString();
        }
        else{
            url2=url2+"?"+params.toString()+"&retCont="+retCont+"&retAct="+retAct+"&_parqs="+_rparqs;
        }
        window.location.href = url2;
    }
    else{
        var url22=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id+"?"+model;//+"?panel=1";//&sortExpression="+sortExpression.toString()+"&filterExpression="+filterExpression.toString()+"&IdGrid="+_gridId.toString();
        if (retCont==controller){
            url22=url22+"?"+params.toString();
        }
        else{
            url22=url22+"?"+params.toString()+"&retCont="+retCont+"&retAct="+retAct+"&_parqs="+_rparqs;
        }
        window.location.href = url22;    }
    }
    else{
        var url=window.location.href;
        window.location.href = url;
    }

}
function sortTable(_ncol,_gridId )
{
    //document.cookie="name=value;path=/";
    var sortorder = getCookie(cookieName("sortorder",_gridId))
    var _sortorder = parseInt(sortorder);
    if (_sortorder ==0){sortorder=1;}
    else{sortorder =0;}
    document.cookie = cookieName("sortorder",_gridId)+"="+sortorder.toString()+";path=/";
    var _mcolumn = parseInt(_ncol);

    document.cookie = cookieName("colorderton",_gridId)+"="+_mcolumn.toString()+";path=/";
    document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
    document.cookie = cookieName("currentpage",_gridId)+"=0"+";path=/";
    var url=window.location = window.location.href;//.split("?")[0];
    window.location.href = url;

}
function filterTable(_ncol,_gridId )
{
    var _texttofilter = document.getElementById(nameOf('filter-'+_ncol.toString(),_gridId)).value;

    document.cookie = cookieName("filterby-"+_ncol.toString(),_gridId)+"="+_texttofilter.toString()+";path=/";

    var current_page=1;   //cuando inicia o resetea un filtro pasa a la primera pagina del resultado
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString()+";path=/";

    document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
    document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";

    var url=window.location = window.location.href;//.split("?")[0];
    window.location.href = url;

}
function uncheck_all_except(_nr,_mxrow,_gridId)
{
    var _maxrows = parseInt(_mxrow);
    var _nrow = parseInt(_nr);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
        if (_nri==_nrow){
        }
        else {
            try{
            var ckBox=document.getElementById(nameOf(_nri.toString().trim(),_gridId));
            if (ckBox.checked){
                ckBox.checked=false;
                var trRow = document.getElementById(nameOf('dd_div_cof',_gridId.toString().trim()+"-"+_nri.toString().trim()));
                if (_nri%2==0 )
                {trRow.className = "line-text-pri";}
                else{trRow.className ="line-text-alt";}
            break;}}
            catch(error){
                //alert(error);
                break;}
        }
    }
}
function uncheck_all_editions(_mxrow,_gridId)
{
    var _maxrows = parseInt(_mxrow);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
            try{
                ckBox=document.getElementById(nameOf(_nri.toString().trim(),"e"+_gridId));
                ckBox.checked=false;
                }
            catch(error){
                //alert(error);
                break;}
              
            var divf = document.getElementById(nameOf('dd_div_cof',_gridId+"-"+_nri.toString().trim()));
            var dive = document.getElementById(nameOf('dd_div_coe',_gridId+"-"+_nri.toString().trim()));
            dive.hidden=true;//.setAttribute("hidden", "hidden");;//divf.style.visibility = 'hidden';
            divf.hidden=false;//.removeAttribute("hidden"); //dive.style.visibility = 'visible';
    }
}
function selectionchange(_nr,_mxrow,_gridId)
{   
   //hide edition tr and show fixed tr (unchecked)
    editLine(_mxrow,_gridId,0);
    uncheck_all_editions(_mxrow,_gridId);

    var _npag = parsenum(getCookie(cookieName("currentpage",_gridId)));
    var _maxrows = parseInt(_mxrow);
    var _nrow = parseInt(_nr);
    var checkbox = document.getElementById(nameOf(_nr.toString(),_gridId));
    var btnact = document.getElementById(nameOf("btn_dropdn",_gridId));
    var _id = checkbox.value.toString(); 
    var div = document.getElementById(nameOf('dd_div_btn',_gridId));
    //var trRow = document.getElementById(nameOf('dd_div_cof',_gridId.toString().trim()+"-"+_nrow.toString().trim()));
    var trRow = document.getElementById(nameOf('dd_div_cof',_gridId.toString().trim()+"-"+_nrow.toString().trim()));
    if (checkbox.checked){
        div.style.visibility = 'visible';
        trRow.className = 'line-text-sel';    
        document.cookie = cookieName("rowselected",_gridId)+"="+_nrow.toString()+";path=/";
        document.cookie = cookieName("proselected",_gridId)+"="+_npag.toString()+";path=/";
    }
    else{
        div.style.visibility = 'hidden';
        if (_nrow%2==0 )
        {trRow.className = "line-text-pri";}
        else{trRow.className ="line-text-alt";}
        document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
        document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";
    }
    uncheck_all_except(_nr,_mxrow,_gridId);
}
function eselectionchange(_nr,_mxrow,_gridId)
{   
    document.cookie = cookieName("ineditionmode-"+_nr.toString().trim(),_gridId)+"=0"+";path=/";
    //22-06-07 ahora llaga por click en boton ok sobre el checkbox
    //alert("selectionchanged");
    //hide edition tr and show fixed tr (unchecked)
    editLine(_mxrow,_gridId,0);
    uncheck_all_except(0,_mxrow,_gridId);  //uncheck all
    var trRow = document.getElementById(nameOf('dd_div_cof',_gridId.toString().trim()+"-"+_nr.toString().trim()));
    var div = document.getElementById(nameOf('dd_div_btn',_gridId));
    div.style.visibility = 'hidden';
    if (_nrow%2==0 )
    {trRow.className = "line-text-pri";}
    else{trRow.className ="line-text-alt";}
    document.cookie = cookieName("rowselected",_gridId)+"=0"+";path=/";
    document.cookie = cookieName("proselected",_gridId)+"=0"+";path=/";

}
function prevPage(_current_page,_gridId)
{
    var current_page = parseInt(_current_page);
    if (current_page > 1) {
        current_page--;
    }
    var url=window.location = window.location.href;//.split("?")[0];
    //url +=  "?current_page=" + current_page.toString() ; //'?param=1'

    //var _tcur_page = document.getElementById('curpage');
    //_tcur_page.value=current_page.toString();
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString()+";path=/";
    window.location.href = url;
    
}
function nextPage(_current_page,_num_pages,_gridId)
{
    var current_page = parseInt(_current_page);
    var num_pages = parseInt(_num_pages);
    if (current_page < num_pages) {
        current_page++;
    }
    //const ret = [];
    //ret.push(encodeURIComponent("current_page") + '=' + encodeURIComponent(current_page));

    var url=window.location = window.location.href;//.split("?")[0];
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString()+";path=/";
    window.location.href = url;
    
}
function gotoPage(_current_page,_num_pages,_gridId)
{
    var _new_page = document.getElementById(nameOf('newpage',_gridId)).value;
    try{
    var new_page = parseInt(_new_page);
    var num_pages = parseInt(_num_pages);
    }
    catch{new_page=_current_page;}
    if (new_page > num_pages) {
        new_page=num_pages;
    }
    if (new_page < 1) {
        new_page=1;
    }
    if (isNaN(new_page)){new_page=_current_page;}
    //const ret = [];
    //ret.push(encodeURIComponent("current_page") + '=' + encodeURIComponent(current_page));

    var url=window.location = window.location.href;//.split("?")[0];
    //url +=  "?current_page=" + new_page.toString() ; //'?param=1'
    //url += ret ; //'?param=1'

    document.cookie = cookieName("currentpage",_gridId)+"="+new_page.toString()+";path=/";

    window.location.href = url;
    
}
function parsenum(x)
{
    x=parseInt(x);
    if (isNaN(x)){x=0;}
    return x;

}
function myFunc() {
    //lo debe hacer para todos los controles grid  (no conocemos el control en este momento)
    //debemos disponer de una coleccion de los controles grid que hay en la pagina 
    //tal vez pueden estar en una cookie
    //y hacer esto para cada uno de ellos
    var cookinam = cookieNameS("gridcount");
    var gridcount = getCookie(cookinam);//100;//----numero de controles grid en la misma pagina getCookie(cookinam);
    for (i=1;i<=gridcount;i++)
    {   
        var _gridId = i.toString();
        var div = document.getElementById(nameOf('dd_div_btn',_gridId));
        //var _tcur_page = document.getElementById('curpage').value;
        let x = parsenum(getCookie(cookieName("currentpage",_gridId)));
        try{
            document.getElementById(nameOf('curpage',_gridId)).value=x;}
        catch (error) {}
    
        let n = getCookie(cookieName("rowselected",_gridId));
        let p = getCookie(cookieName("proselected",_gridId));
            if (p==x && p>0){
                try{document.getElementById(nameOf(n,_gridId)).checked=true;}
                catch(error){
                    try{div.style.visibility = 'hidden';}
                    catch{}
                }
                if (n>0){try{div.style.visibility = 'visible';}catch{}}
                else{try{div.style.visibility = 'hidden';}catch{}}
            }
            else{
                try{div.style.visibility = 'hidden';}
                catch{}
            }
        
        }
}
function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for(let i = 0; i <ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
function cookieName(_cookie,_gridId)
{
    //var uId = document.getElementById(_gridId+'-'+'cntrl_id').value.Tostr();
    var _newName="_"+_gridId.toString()+"-"+_cookie.toString(); 
    return _newName;
}
function cookieNameS(_cookie)
{
    //var uId = document.getElementById(_gridId+'-'+'cntrl_id').value.Tostr();
    var _newName=_cookie.toString(); 
    return _newName;
}
function nameOf(_control,_gridId)
{
    return "_"+_gridId+"-"+_control;
}
function exportData(_ncols,_gridId){
    /* Get the HTML data using Element by Id */
    var table = document.getElementById(nameOf("h-data-table",_gridId));
    _ncols = _ncols-1  //hidden table not include first (select) column
    var start_col=0;  //start with 0 or 1 to permit or avoid first column (select)

    /* Declaring array variable */
    var rows =[];
    var colm =[];
      //iterate through rows of table
    for(var i=0,row; row = table.rows[i];i++){
        //rows would be accessed using the "row" variable assigned in the for loop
        //Get each cell value/column from the row
        var scolm="";
        for (var c=start_col;c<_ncols;c++)  
        {
            colm[c]=row.cells[c].innerText;
            scolm+=row.cells[c].innerText.replace(/,/g, '-');
            if (c<_ncols-1){scolm+=",";}
        }
        /*
        column1 = row.cells[0].innerText;
        column2 = row.cells[1].innerText;
        column3 = row.cells[2].innerText;
        column4 = row.cells[3].innerText;
        column5 = row.cells[4].innerText;
        */
    /* add a new records in the array */
        rows.push([scolm]);
        /*
        rows.push(
            [
                column1,
                column2,
                column3,
                column4,
                column5
            ]
        );
        */
 
        }
        csvContent = "data:text/csv;charset=utf-8,";
         /* add the column delimiter as comma(,) and each row splitted by new line character (\n) */
        rows.forEach(function(rowArray){
            row = rowArray.join(",");
            csvContent += row + "\r\n";
        });
 
        /* create a hidden <a> DOM node and set its download attribute */
        var encodedUri = encodeURI(csvContent);
        var link = document.createElement("a");
        link.setAttribute("href", encodedUri);
        link.setAttribute("download", "Data_Table.csv");
        document.body.appendChild(link);
         /* download the data file named "Stock_Price_Report.csv" */
        link.click();
}