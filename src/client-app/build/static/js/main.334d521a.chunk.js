(this["webpackJsonpclient-app"]=this["webpackJsonpclient-app"]||[]).push([[0],{101:function(e,t,n){"use strict";n.r(t);var a={};n.r(a),n.d(a,"loadRequest",(function(){return f})),n.d(a,"loadSuccess",(function(){return v})),n.d(a,"loadFailure",(function(){return g}));var r,c=n(0),l=n.n(c),o=n(17),u=n.n(o),i=n(35),s=n(8),m=function(){return c.createElement("div",null,c.createElement("h1",null,"Sistema de gest\xe3o de livros"))},b=n(30),d=n(31),E=n(38),p=n(36),h=n(15),O=n(41);!function(e){e.LOAD_REQUEST="@books/LOAD_REQUEST",e.LOAD_SUCCESS="@books/LOAD_SUCCESS",e.LOAD_FAILURE="@books/LOAD_FAILURE"}(r||(r={}));var f=function(){return Object(O.action)(r.LOAD_REQUEST)},v=function(e){return Object(O.action)(r.LOAD_SUCCESS,{data:e})},g=function(){return Object(O.action)(r.LOAD_FAILURE)},j=function(e){Object(E.a)(n,e);var t=Object(p.a)(n);function n(){return Object(b.a)(this,n),t.apply(this,arguments)}return Object(d.a)(n,[{key:"componentDidMount",value:function(){(0,this.props.loadRequest)()}},{key:"render",value:function(){var e=this.props.books;return l.a.createElement("table",{className:"table table-striped","aria-labelledby":"tabelLabel"},l.a.createElement("thead",null,l.a.createElement("tr",null,l.a.createElement("th",null,"T\xedtulo"),l.a.createElement("th",null,"Autor"),l.a.createElement("th",null,"G\xeaneros"),l.a.createElement("th",null,"Data Cadastro"))),l.a.createElement("tbody",null,function(e){return e&&e.length>0?e.map((function(e){return l.a.createElement("tr",{key:e.id},l.a.createElement("td",null,e.title),l.a.createElement("td",null,e.author?e.author.name:"Indefinido"),l.a.createElement("td",null,"Indefinido"),l.a.createElement("td",null,e.createdAt))})):l.a.createElement("tr",null,l.a.createElement("td",{colSpan:4,align:"center"},"Nenhum dado encontrado"))}(e)))}}]),n}(c.Component),S=Object(i.b)((function(e){return{books:e.books.data}}),(function(e){return Object(h.b)(a,e)}))(j),k=function(){return l.a.createElement(s.c,null,l.a.createElement(s.a,{component:m,path:"/",exact:!0}),l.a.createElement(s.a,{component:m,path:"/home"}),l.a.createElement(s.a,{component:S,path:"/livros"}))},x=n(70),L=n(24),A={data:[],error:!1,loading:!1},y=function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:A,t=arguments.length>1?arguments[1]:void 0;switch(t.type){case r.LOAD_REQUEST:return Object(L.a)(Object(L.a)({},e),{},{loading:!0});case r.LOAD_SUCCESS:return Object(L.a)(Object(L.a)({},e),{},{loading:!1,error:!1,data:t.payload.data});case r.LOAD_FAILURE:return Object(L.a)(Object(L.a)({},e),{},{loading:!1,error:!0,data:[]});default:return e}},w=Object(h.c)({books:y}),U=n(26),D=n.n(U),C=n(23),R=n(59),_=n.n(R).a.create({baseURL:"http://localhost:8000/api"});console.log("address api: ".concat("http://localhost:8000/api"," "));var I=_,F=D.a.mark(T);function T(){var e;return D.a.wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,Object(C.b)(I.get,"book");case 3:return e=t.sent,console.log(e),t.next=7,Object(C.c)(v(e.data));case 7:t.next=13;break;case 9:return t.prev=9,t.t0=t.catch(0),t.next=13,Object(C.c)(g());case 13:case"end":return t.stop()}}),F,null,[[0,9]])}var N=D.a.mark(Q);function Q(){return D.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,Object(C.a)([Object(C.d)(r.LOAD_REQUEST,T)]);case 2:return e.abrupt("return",e.sent);case 3:case"end":return e.stop()}}),N)}var B=Object(x.a)(),M=Object(h.e)(w,Object(h.a)(B));B.run(Q);var z,q,H=M,J=n(22),G=n(103),P=n(106),K=n(107),V=n(105),W=n(69),X=n(104),Y=n(32),Z=n(33),$=Z.b.div(z||(z=Object(Y.a)(["\n    \n    header {\n        color: white;\n    }\n\n    a.navbar-brand {\n    white-space: normal;\n    text-align: center;\n    word-break: break-all;\n    }\n\n    html { font-size: 25px; }\n\n    @media (min-width: 768px) {\n        html { font-size: 16px; }\n    }\n\n    .box-shadow { box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05); }\n\n"]))),ee=function(e){Object(E.a)(n,e);var t=Object(p.a)(n);function n(){var e;Object(b.a)(this,n);for(var a=arguments.length,r=new Array(a),c=0;c<a;c++)r[c]=arguments[c];return(e=t.call.apply(t,[this].concat(r))).state={isOpen:!1},e.toggle=function(){e.setState({isOpen:!e.state.isOpen})},e}return Object(d.a)(n,[{key:"render",value:function(){return c.createElement("header",null,c.createElement($,null,c.createElement(P.a,{bg:"dark",expand:"lg"},c.createElement(G.a,null,c.createElement(P.a.Brand,{as:J.b,to:"/"},"Books-Management"),c.createElement(P.a.Toggle,{"aria-controls":"basic-navbar-nav"}),c.createElement(P.a.Collapse,{id:"basic-navbar-nav"},c.createElement(K.a,{className:"mr-auto"},c.createElement(K.a.Link,{as:J.b,to:"/home"},"Home"),c.createElement(K.a.Link,{as:J.b,to:"/livros"},"Livros")),c.createElement(V.a,{inline:!0},c.createElement(W.a,{type:"text",placeholder:"Search",className:"mr-sm-2"}),c.createElement(X.a,{variant:"outline-success"},"Search")))))))}}]),n}(c.PureComponent),te=function(e){return c.createElement(c.Fragment,null,c.createElement(ee,null),c.createElement(G.a,null,e.children))},ne=function(){return l.a.createElement(i.a,{store:H},l.a.createElement(J.a,null,l.a.createElement(te,null,l.a.createElement(k,null))))},ae=(n(100),Object(Z.a)(q||(q=Object(Y.a)(["\n  * {\n      margin: 0;\n      padding: 0;\n      box-sizing: border-box;\n  }\n  html, body, #root {\n      max-height: 100vh;\n      max-width: 100vw;\n\n      width: 100%;\n      height: 100%;\n  }\n  *, button, input {\n      border: 0;\n      background: none;\n      font-family: --apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif\n  }\n"]))));u.a.render(l.a.createElement(l.a.StrictMode,null,l.a.createElement(ae,null),l.a.createElement(ne,null)),document.getElementById("root"))},72:function(e,t,n){e.exports=n(101)}},[[72,1,2]]]);
//# sourceMappingURL=main.334d521a.chunk.js.map