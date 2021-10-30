/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package controle;



 
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
/**
 *
 * @author Leonardo
 */


public class MinhaConexao {
    private String connectionString;//com.mysql.jdbc.Driverorg.gjt.mm.mysql.Driver
    private String driverName = "com.mysql.jdbc.Driver"; //driver do MySQL
    private String database;
    private String user;
    private String password;
    private String host;
    private Connection connection = null;
    
     //construtor
    public MinhaConexao(String host, String database, String user, String password) {
        System.out.println("minhaconexão"+host+database+user+password);
        this.host = host; //geralmente localhost
        this.database = database; //nome do banco
        this.user = user; //usuario do banco
        this.password = password; //senha do usuario
        //mysql usa a porta 3306//jdbc:mysql://localhost:3306/minhabase
        connectionString = "jdbc:mysql://" + host + ":3306/" + database;//string de conexao
        System.out.println("String de conexão:"+connectionString);
    }
    
    
    //conectar no banco
    public Connection connect() throws SQLException {
        System.out.println("Entrou em conectar");
        try {
            Class.forName(this.driverName);
            //faz a conexao e retorna
            this.connection = DriverManager.getConnection(connectionString, this.user, this.password);
           System.out.println("Vai sair de conectar");
            return this.connection;
        }
        catch (ClassNotFoundException ex){
            System.out.println("Entrou em conectar Class "+ex);
            throw new SQLException(ex.getMessage());
        }
        catch (SQLException ex) {
            System.out.println("Entrou em conectar SQL"+ ex);
            throw new SQLException(ex.getMessage());
        }
    }
 
    //fecha conexao
    public void close() throws SQLException{
        try {
            connection.close();
        } catch (SQLException ex) {
            throw new SQLException(ex.getMessage());
        }
    }
    
   
    
    
    
   
}
