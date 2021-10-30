<%-- 
    Document   : index
    Created on : 27/04/2012, 19:57:19
    Author     : ALUNOS
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
         <!--
   
    -->
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>Template </title>

    <link rel="stylesheet" href="style.css" type="text/css" media="screen" />
    <!--[if IE 6]><link rel="stylesheet" href="style.ie6.css" type="text/css" media="screen" /><![endif]-->
    <!--[if IE 7]><link rel="stylesheet" href="style.ie7.css" type="text/css" media="screen" /><![endif]-->

    <script type="text/javascript" src="jquery.js"></script>
    <script type="text/javascript" src="script.js"></script>
    </head>
    <body>
       <div id="art-main">
	     <div class="art-sheet">
		 <div class="art-sheet-tl"></div>
            <div class="art-sheet-tr"></div>
            <div class="art-sheet-bl"></div>
            <div class="art-sheet-br"></div>
            <div class="art-sheet-tc"></div>
            <div class="art-sheet-bc"></div>
            <div class="art-sheet-cl"></div>
            <div class="art-sheet-cr"></div>
            <div class="art-sheet-cc"></div>
			<div class="art-sheet-body">
					<%@ include file="header.jsp" %>
					<%@ include file="art-nav.jsp" %>
			
					<div class="art-content-layout">
						<%@ include file="art-sidebar1.jsp" %>
						
						<div class="art-layout-cell art-content">
					
							
						</div>
						<%@ include file="art-sidebar2.jsp" %>
						
						
					</div>
					<div class="cleared"></div>
					<div class="art-footer">
                    <div class="art-footer-t"></div>
					<%@ include file="art-footer-body.jsp" %>
                   
                </div>
					<div class="cleared"></div>
		
           
            
             
           
		
			</div>
		</div>
		<div class="cleared"></div>
        <p class="art-page-footer"><a href="http://prorfessorleonardo2.bogspot.com/">Web Template</a> criado com arte.</p>
        </div>
    </body>
</html>
