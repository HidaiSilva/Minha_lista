/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package controle;

/**
 *
 * @author Leonardo
 */
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.StringTokenizer;
import java.util.regex.*;
import java.sql.Connection;
import java.sql.DriverManager;

public class BeanDeCadastro {
    
    private String nome=null;
    private String senha=null;
    private String confirmaSenha=null;
    private String email=null;
    private String confirmaEmail=null;
    private String CPF=null;
    
   private boolean dadosValidos=false;
    
    private String mensagemBanco=null;
    private ArrayList listaDeErros;
    
    public boolean seTodosDadosSaoValidos(){
        if(listaDeErros.isEmpty()){
            return true;
        }else{
            return false;
        }
    }

    public String getMensagemBanco(){
        if(seTodosDadosSaoValidos()){
            System.out.println("getMensagemBanco"+nome+senha+email+CPF);
            insereDados();
            return "Todos os dados  foram validados";
            
        }else{
            String msg="";
            for(int i=0;i<listaDeErros.size();i++){
                msg+=listaDeErros.get(i).toString()+"jj"+"<br>";
                
                
            }
            return "Nem todo os dados  foram validados <br>"+msg;
        }
      
    }

    public void setMensagemBanco(String mensagemBanco) {
        this.mensagemBanco = mensagemBanco;
    }
    
    private String erroNome=null;
    private String erroSenha=null;
    private String erroConfirmaSenha=null;
    private String erroEmail=null;
    private String erroConfirmaEmail=null;
    private String erroCPF=null;

    public String getErroCPF() {
       
        return  "<span class='erro'>" + erroCPF + "</span>";
    }
    
    private String tarefa=null;

    public String getErroConfirmaSenha() {
        return  "<span class='erro'>" + erroConfirmaSenha + "</span>";
    }

    public void setErroConfirmaSenha(String erroConfirmaSenha) {
        this.erroConfirmaSenha = erroConfirmaSenha;
    }
  

    public String getTarefa() {
        return tarefa;
    }

    public void setTarefa(String tarefa) {
        this.tarefa = tarefa;
    }

    public String getErroNome() {
        
        
           
        return "<span class='erro'>" + erroNome + "</span>";
                
    }

    public String getErroConfirmaEmail() {
       
         return  "<span class='erro'>" +  erroConfirmaEmail + "</span>";
    }

    public void setErroConfirmaEmail(String erroConfirmaEmail) {
        this.erroConfirmaEmail = erroConfirmaEmail;
    }

    public String getErroEmail() {
       return "<span class='erro'>" + erroEmail + "</span>";
       
    }

    public void setErroEmail(String erroEmail) {
        this.erroEmail = erroEmail;
    }

    public String getErroSenha() {
        return "<span class='erro'>" + erroSenha + "</span>";
    }

    public String getCPF() {
        return CPF;
    }

    public void setCPF(String CPF) {
        this.CPF = CPF;
        erroCPF= validarCPF(CPF);
        if(!erroCPF.equals("")){
            listaDeErros.add(erroCPF);
        }
        
    }
   

    public String getConfirmaEmail() {
        return confirmaEmail;
    }

    public void setConfirmaEmail(String confirmaEmail) {
       
        this.confirmaEmail = confirmaEmail;
        if(!email.equals(confirmaEmail)){
            
            erroConfirmaEmail+="Emails diferentes";
            listaDeErros.add(erroConfirmaEmail);
        }
    }

    public String getConfirmaSenha() {
         System.out.println("recebeu nome como "+ confirmaSenha);
        return confirmaSenha != null ? confirmaSenha : "";
    }

    public void setConfirmaSenha(String confirmaSenha) {
         this.confirmaSenha = confirmaSenha;
         if(!confirmaSenha.equals(senha)){
            erroConfirmaSenha="As senhas estão diferentes ";
             listaDeErros.add(erroConfirmaSenha);
         }     
    }
   
    
    

    //cria um bean com todo os valores vazios
    public BeanDeCadastro() {
        nome="";
        senha="";
        confirmaSenha="";
        email="";
        confirmaEmail="";
        CPF="";
        
        
        mensagemBanco="";
      
        erroNome="";
        erroSenha="";
        erroConfirmaSenha="";
        erroEmail="";
        erroConfirmaEmail="";
        erroCPF="";
        tarefa="";
        
        
        listaDeErros = new ArrayList();
        
    }
  
 
   

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
        
       
        if(!validarEmail(email)){
            
            erroEmail+="Email inválido";
            listaDeErros.add(erroEmail);
        }
     
    }

    public String getNome() {
       return nome != null ? nome : "";
    }

    public void setNome(String nome) {
        
        this.nome = nome;
       
        if(nome.equals("")||nome==null||nome.equals(" ")){
            erroNome+="Campo obrigatório ";
        }
        
        if(nome.length()<3){
            erroNome+="Nome com poucas letras<br />";
            listaDeErros.add("Erro no nome");
        }
        if(!validarString(nome)){
            
            erroNome+="Nome não pode conter dígitos";
            listaDeErros.add("Erro no nome");
        }
     
    }

    public String getSenha() {
        return senha != null ? senha : "";
    }

    public void setSenha(String senha) {
        
        this.senha = senha;
         if(senha.equals("")||senha==null||senha.equals(" ")){
           
           
        }
        
        if(senha.length()<6){
            erroSenha+="A Senha deve ter no minímo 6 caracteres<br />";
           listaDeErros.add(erroSenha);
        }
       
    }
    
    public boolean validarString(String _input) {
        //converte para um array de chars
        char[] chars = _input.toCharArray();
        // se encontrar um dígito sequer, retorna false
        for(int i = 0; i < chars.length; i++) {
            //testa para ver se o char  na posição i é dígito númerico
            if(Character.isDigit(chars[i])){
                return false;
            }
        }
        //retorna true se não encontrou nenhum dígito númerico
        return true;
    }
    
      public boolean validarEmail(String email){
          
          // Configura a string de padrão do email
          Pattern p = Pattern.compile(".+@.+\\.[a-z]+");
          // Compara o email recebido com o padrão
          Matcher m = p.matcher(email);
       
          // verifica se casou
          boolean matchFound = m.matches();
          StringTokenizer st = new StringTokenizer(email, ".");
          String lastToken = null;
          while (st.hasMoreTokens()) {
              lastToken = st.nextToken();
          }
          if (matchFound && lastToken.length() >= 2&& email.length() - 1 != lastToken.length()) {
              // validate the country code
              return true;
          }
          else{
              return false;
          }
      }   
      
      public String validarCPF(String cpf) {
        //char ch[]=new ch[12];
        String str=""; 
        if(cpf.length()==12){
        str = cpf.substring(0, 9);
        int dv1 = Integer.parseInt(cpf.substring(10, 11));
        int dv2 = Integer.parseInt(cpf.substring(11, 12));

        int soma1 = 0;
        int soma2 = 0;
        int valor = 0;
        int resultado = 0;

        int dig1 = 0;
        int dig2 = 0;
        try {
            long n1 = Long.parseLong(str);
            for (int i = 0; i < str.length(); i++) {
                soma1 += (str.charAt(i) - '0') * (str.length() + 1 - i);
                soma2 += (str.charAt(i) - '0') * (str.length() + 2 - i);
            }

            resultado = soma1 % 11;
           // System.out.println("resultado vale " + resultado);
            if (resultado == 1 || resultado == 0) {
                dig1 = 0;
            } else {
                dig1 = 11 - resultado;
            }
            soma2 = soma2 + dig1 * 2;
            resultado = soma2 % 11;
           // System.out.println("resultado vale " + resultado);
            if (resultado == 1 || resultado == 0) {
                dig2 = 0;
            } else {
                dig2 = 11 - resultado;
            }
            str = "Digito1 vale " + dig1 + " Dig 2 vale " + dig2;
            if (dv1 == dig1 && dv2 == dig2) {
                str = "";
            } else {
                str = "CPF inválido";
            }
        } catch (Exception e) {
            str = "Somente numeros são permitidos";

        }

        }
        else{
            
            str="CPF no formato xxxyyyzzz-nn";
        }
        return str;
    }
    
    public void insereDados(){
         System.out.println("insereDados");
         
          try {
            //instancia classe de conexao
            MinhaConexao conexao = new MinhaConexao("localhost", "minhabase", "root", "ALUNOS");
            //conecta no banco
            Connection connection = conexao.connect();
              //cria o statment e realiza a consulta
            Statement st = connection.createStatement();
            /*INSERT INTO usuarios
            //             (nome, senha, email, CPF)
VALUES      //  ('SsS', 'sS', 'sSsS', '45555')
        */
            System.out.println(nome+senha+email+CPF);
            String sql = "INSERT INTO usuarios (nome,senha,email,CPF) VALUES "+
                    "('"+nome+"','"+senha+"','"+email+"','"+CPF+"')";
            int contador = st.executeUpdate(sql);
            if(contador>0){
                System.out.println("Um registro inserido");
            }
            //fecha a conexao com o banco
            connection.close();
          }
          catch(Exception e){
              System.out.println(e.toString());
          }
            
    }
    
    public void exibeDados(){
         System.out.println("insereDados");
         
          try {
            //instancia classe de conexao
            MinhaConexao conexao = new MinhaConexao("localhost", "minhabase", "root", "ALUNOS");
            //conecta no banco
            Connection connection = conexao.connect();
              //cria o statment e realiza a consulta
            Statement st = connection.createStatement();
            String sql = "SELECT * FROM usuarios";
            ResultSet rs = st.executeQuery(sql);
            while(rs.next()) {
                System.out.println(rs.getString(2) + "<br />"); //mostra o campo 1
            }
            //fecha a conexao com o banco
            connection.close();
          }
          catch(Exception e){
              System.out.println(e.toString());
          }
            
    }
      
}
