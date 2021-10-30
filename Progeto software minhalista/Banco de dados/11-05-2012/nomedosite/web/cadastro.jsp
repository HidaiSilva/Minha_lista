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
	  <jsp:useBean id='form' class='controle.BeanDeCadastro' scope='page'>
       <jsp:setProperty name='form' property='*'/>
       </jsp:useBean>  
	
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
					<div class="art-block">
							<div class="art-block-tl"></div>
                              <div class="art-block-tr"></div>
                              <div class="art-block-bl"></div>
                              <div class="art-block-br"></div>
                              <div class="art-block-tc"></div>
                              <div class="art-block-bc"></div>
                              <div class="art-block-cl"></div>
                              <div class="art-block-cr"></div>
                              <div class="art-block-cc"></div>
                              <div class="art-block-body"> 
                                          <div class="art-blockheader">
                                              <div class="l"></div>
                                              <div class="r"></div>
                                              <h3 class="t">Cadastro</h3>
                                          </div>
                                          <div class="art-blockcontent">
                                              <div class="art-blockcontent-body">
                                                          <div>
														  <form name="f1"  method="get"      onSubmit='return validate()' action="#" >
                                                    <p>	
                                                        Nome:
                                                    </p>
                                                    <p>
                                                        <input type="text" name="nome" value='<%=form.getNome()%>' size="25"/>
                                                        
                                                         <%=form.getErroNome()%>
                                                        
                                                    </p>
                                                    <p> 
                                                        Senha:
                                                    </p>
                                                    <p>
                                                        <input type="password" name="senha" value='<%=form.getSenha()%>' size="25" />
 <%=form.getErroSenha()%>
                                                    </p>

                                                    <p> 
                                                        Confirmação da Senha:
                                                    </p>
                                                    <p>
                                                        <input type="password" name="confirmaSenha" value='<%=form.getSenha()%>' size="25" />
<%=form.getErroConfirmaSenha()%>
                                                    </p>
                                                    </p>
                                                    <p> 
                                                        E-maiil:
                                                    </p>
                                                    <p>
                                                        <input type="text" name="email" value='<%=form.getEmail()%>' size="25" />
<%=form.getErroEmail()%>
                                                    </p>

                                                    <p> 
                                                        Confirmação de Email:
                                                    </p>
                                                    <p>
                                                        <input type="text" name="confirmaEmail" value='<%=form.getConfirmaEmail()%>' size="25" />
<%=form.getErroConfirmaEmail()%>
                                                    </p>	
                                                    <p> 
                                                        CPF:
                                                    </p>
                                                    <p>
                                                        <input type="text" name="CPF" value='<%=form.getCPF()%>' size="25" />
<%=form.getErroCPF()%>
                                                    </p>																
                                                    <span class="art-button-wrapper">
                                                        <span class="art-button-l"> </span>
                                                        <span class="art-button-r"> </span>
                    <input class="art-button" type="submit" name="tarefa" value="Cadastrar" />
                                                    </span>

                                                    <span class="art-button-wrapper">
                                                        <span class="art-button-l"> </span>
                                                        <span class="art-button-r"> </span>
                                                        <input class="art-button" type="reset" name="btnLimpar" value="Limpar" />
                                                    </span>
                                                    <p>
                                                        <a href="http://localhost:8080/nomedosite/index.jsp">Voltar</a> 


                                                    </p>
                                                    <p><%=form.getMensagemBanco()%></p>
                                                </form>
														 
														  
														  
														  </div>
                                          
                                          		<div class="cleared"></div>
                                              </div>
                                          </div>
                          		<div class="cleared"></div>
                              </div>
                          </div><!--fim -->
							
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
