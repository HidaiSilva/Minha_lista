<%-- 
    Document   : recebe.jsp
    Created on : 27/04/2012, 20:05:15
    Author     : ALUNOS
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello World!</h1>
        <% 
        String nome = request.getParameter("nome");
        String senha = request.getParameter("senha");
        String confirmaSenha = request.getParameter("confirmaSenha");
        String email = request.getParameter("email");
        String confirmaEmail = request.getParameter("confirmaEmail");
        String CPF = request.getParameter("CPF");
        String errorMsg = "";
        boolean errorDetected = false;
        if(nome.equals("") || senha.equals("") || senha.equals("")||CPF.equals("")) {
            errorMsg += "Preencha todos os campos.";
            errorDetected = true;
        }
        if(email.indexOf("@") == -1 ||(!email.endsWith(".com") && !email.endsWith(".edu"))) {
            if(errorMsg.length() > 0){
                errorMsg += "<br>";
            }
            errorMsg += "Endereço de Email deve conter @ e " + "terminar com .com ou .edu";
            errorDetected = true;
        }
        if(errorDetected) { %>
        <%=errorMsg%>
        <jsp:include page='form.jsp' flush='true'/>
        <% } else { %>
        <jsp:forward page='registrationComplete.jsp'/>
        <% } %>
    </body>
</html>
