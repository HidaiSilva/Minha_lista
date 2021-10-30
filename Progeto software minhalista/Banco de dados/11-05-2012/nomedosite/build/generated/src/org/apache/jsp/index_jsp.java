package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class index_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.Vector _jspx_dependants;

  static {
    _jspx_dependants = new java.util.Vector(8);
    _jspx_dependants.add("/header.jsp");
    _jspx_dependants.add("/art-nav.jsp");
    _jspx_dependants.add("/art-sidebar1.jsp");
    _jspx_dependants.add("/art-sidebar2.jsp");
    _jspx_dependants.add("/login.jsp");
    _jspx_dependants.add("/boletim.jsp");
    _jspx_dependants.add("/contato.jsp");
    _jspx_dependants.add("/art-footer-body.jsp");
  }

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public Object getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("<!DOCTYPE html>\r\n");
      out.write("<html>\r\n");
      out.write("    <head>\r\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n");
      out.write("        <title>JSP Page</title>\r\n");
      out.write("         <!--\r\n");
      out.write("   \r\n");
      out.write("    -->\r\n");
      out.write("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />\r\n");
      out.write("    <title>Template </title>\r\n");
      out.write("\r\n");
      out.write("    <link rel=\"stylesheet\" href=\"style.css\" type=\"text/css\" media=\"screen\" />\r\n");
      out.write("    <!--[if IE 6]><link rel=\"stylesheet\" href=\"style.ie6.css\" type=\"text/css\" media=\"screen\" /><![endif]-->\r\n");
      out.write("    <!--[if IE 7]><link rel=\"stylesheet\" href=\"style.ie7.css\" type=\"text/css\" media=\"screen\" /><![endif]-->\r\n");
      out.write("\r\n");
      out.write("    <script type=\"text/javascript\" src=\"jquery.js\"></script>\r\n");
      out.write("    <script type=\"text/javascript\" src=\"script.js\"></script>\r\n");
      out.write("    </head>\r\n");
      out.write("    <body>\r\n");
      out.write("       <div id=\"art-main\">\r\n");
      out.write("\t     <div class=\"art-sheet\">\r\n");
      out.write("\t\t <div class=\"art-sheet-tl\"></div>\r\n");
      out.write("            <div class=\"art-sheet-tr\"></div>\r\n");
      out.write("            <div class=\"art-sheet-bl\"></div>\r\n");
      out.write("            <div class=\"art-sheet-br\"></div>\r\n");
      out.write("            <div class=\"art-sheet-tc\"></div>\r\n");
      out.write("            <div class=\"art-sheet-bc\"></div>\r\n");
      out.write("            <div class=\"art-sheet-cl\"></div>\r\n");
      out.write("            <div class=\"art-sheet-cr\"></div>\r\n");
      out.write("            <div class=\"art-sheet-cc\"></div>\r\n");
      out.write("\t\t\t<div class=\"art-sheet-body\">\r\n");
      out.write("\t\t\t\t\t");
      out.write("<div class=\"art-header\">\r\n");
      out.write("                        <div class=\"art-header-jpeg\"></div>\r\n");
      out.write("                    <div class=\"art-logo\">\r\n");
      out.write("                     <h1 id=\"name-text\" class=\"art-logo-name\"><a href=\"#\">Decora casa</a></h1>\r\n");
      out.write("                     <h2 id=\"slogan-text\" class=\"art-logo-text\">Decora com coraç?o</h2>\r\n");
      out.write("                    </div>\r\n");
      out.write("                </div>");
      out.write("\r\n");
      out.write("\t\t\t\t\t");
      out.write("<div class=\"art-nav\">\r\n");
      out.write("                \t<div class=\"l\"></div>\r\n");
      out.write("                \t<div class=\"r\"></div>\r\n");
      out.write("                \t<ul class=\"art-menu\">\r\n");
      out.write("                \t\t<li>\r\n");
      out.write("                \t\t\t<a href=\"index.jsp\" class=\"active\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Home</span></a>\r\n");
      out.write("                \t\t</li>\r\n");
      out.write("                \t\t<li>\r\n");
      out.write("                \t\t\t<a href=\"#\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Galeria</span></a>\r\n");
      out.write("                \t\t\t<ul>\r\n");
      out.write("                \t\t\t\t<li><a href=\"#\">Produtos</a>\r\n");
      out.write("                \t\t\t\t\t<ul>\r\n");
      out.write("                \t\t\t\t\t\t<li><a href=\"#\">Salas de Estar</a></li>\r\n");
      out.write("                \t\t\t\t\t\t<li><a href=\"#\">Salas de Jantar</a></li>\r\n");
      out.write("                \t\t\t\t\t\t<li><a href=\"#\">Cozinhas</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">Quartos</a></li>\r\n");
      out.write("                \t\t\t\t\t</ul>\r\n");
      out.write("                \t\t\t\t</li>\r\n");
      out.write("                \t\t\t\t<li><a href=\"#\">Localizaç?o</a></li>\r\n");
      out.write("                \t\t\t\t<li><a href=\"#\">Contatos</a></li>\r\n");
      out.write("                \t\t\t</ul>\r\n");
      out.write("                \t\t</li>\t\t\r\n");
      out.write("                \t\t<li>\r\n");
      out.write("                \t\t\t<a href=\"#\"><span class=\"l\"></span><span class=\"r\"></span><span class=\"t\">Sobre  nos</span></a>\r\n");
      out.write("                \t\t</li>\r\n");
      out.write("                \t</ul>\r\n");
      out.write("                </div>");
      out.write("\r\n");
      out.write("\t\t\t\r\n");
      out.write("\t\t\t\t\t<div class=\"art-content-layout\">\r\n");
      out.write("\t\t\t\t\t\t");
      out.write("<div class=\"art-layout-cell art-sidebar1\">\r\n");
      out.write("\t\t\t\t\t\t\t<div class=\"art-block\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-tl\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-tr\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-bl\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-br\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-tc\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-bc\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-cl\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-cr\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-cc\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"art-block-body\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"art-blockheader\">\r\n");
      out.write("                                              <div class=\"l\"></div>\r\n");
      out.write("                                              <div class=\"r\"></div>\r\n");
      out.write("                                              <h3 class=\"t\">Destaques</h3>\r\n");
      out.write("                                          </div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"art-blockcontent\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"art-blockcontent-body\">\r\n");
      out.write("                                                          <div>\r\n");
      out.write("                                                                            <ul>\r\n");
      out.write("                                                                             <li><a href=\"index.jsp\">Home</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\">Overview</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\">Demo</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\">Download</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\">FAQ</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\">Hyperlink</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\" class=\"visited\">Visited link</a></li>\r\n");
      out.write("                                                                             <li><a href=\"#\" class=\"hover\">Hovered link</a></li>\r\n");
      out.write("                                                                            </ul>\r\n");
      out.write("                                                                            \r\n");
      out.write("                                                                            <p><b>Jun 14, 2008</b><br />\r\n");
      out.write("                                                                            Aliquam sit amet felis. Mauris semper,\r\n");
      out.write("                                                                            velit semper laoreet dictum, quam\r\n");
      out.write("                                                                            diam dictum urna, nec placerat elit\r\n");
      out.write("                                                                            nisl in quam. Etiam augue pede,\r\n");
      out.write("                                                                            molestie eget, rhoncus at, convallis\r\n");
      out.write("                                                                            ut, eros. Aliquam pharetra.<br />\r\n");
      out.write("                                                                            <a href=\"javascript:void(0)\">Read more...</a></p>\r\n");
      out.write("                                                          \r\n");
      out.write("                                                                            <p><b>Aug 24, 2008</b><br />\r\n");
      out.write("                                                                            Aliquam sit amet felis. Mauris semper,\r\n");
      out.write("                                                                            velit semper laoreet dictum, quam\r\n");
      out.write("                                                                            diam dictum urna, nec placerat elit\r\n");
      out.write("                                                                            nisl in quam. Etiam augue pede,\r\n");
      out.write("                                                                            molestie eget, rhoncus at, convallis\r\n");
      out.write("                                                                            ut, eros. Aliquam pharetra.<br />\r\n");
      out.write("                                                                            <a href=\"javascript:void(0)\">Read more...</a></p>\r\n");
      out.write("                                                                            </div>\r\n");
      out.write("                                          \r\n");
      out.write("                                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                                              </div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"cleared\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t<div class=\"cleared\"></div>\r\n");
      out.write("\t\t\t\t\t\t</div>");
      out.write("\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t<div class=\"art-layout-cell art-content\">\r\n");
      out.write("\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t");
      out.write("<div class=\"art-layout-cell art-sidebar2\">\r\n");
      out.write("<div class=\"art-block\">\r\n");
      out.write("\t\t\t\t\t\t\t<div class=\"art-block-tl\"></div>\r\n");
      out.write("                              <div class=\"art-block-tr\"></div>\r\n");
      out.write("                              <div class=\"art-block-bl\"></div>\r\n");
      out.write("                              <div class=\"art-block-br\"></div>\r\n");
      out.write("                              <div class=\"art-block-tc\"></div>\r\n");
      out.write("                              <div class=\"art-block-bc\"></div>\r\n");
      out.write("                              <div class=\"art-block-cl\"></div>\r\n");
      out.write("                              <div class=\"art-block-cr\"></div>\r\n");
      out.write("                              <div class=\"art-block-cc\"></div>\r\n");
      out.write("                              <div class=\"art-block-body\">\r\n");
      out.write("                                          <div class=\"art-blockheader\">\r\n");
      out.write("                                              <div class=\"l\"></div>\r\n");
      out.write("                                              <div class=\"r\"></div>\r\n");
      out.write("                                              <h3 class=\"t\">Login</h3>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                                          <div class=\"art-blockcontent\">\r\n");
      out.write("                                              <div class=\"art-blockcontent-body\">\r\n");
      out.write("                                                          <div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t  <form name=\"f1\"  method=\"get\"       action=\"recebe.jsp\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNome:\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" name=\"txtNome\" value=\"\" size=\"25\" />\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p> \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tSenha:\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"password\" name=\"txtSenha\" value=\"\" size=\"25\" />\r\n");
      out.write("            \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n");
      out.write("            \r\n");
      out.write("                                                         \r\n");
      out.write("                                                          \t\t\t\t\t\t\t\t\t\t\t\t  \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-wrapper\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-l\"> </span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-r\"> </span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input class=\"art-button\" type=\"submit\" name=\"btnEnviar\" value=\"Enviar\" />\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t  \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-wrapper\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-l\"> </span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"art-button-r\"> </span>\r\n");
      out.write("                                                                <input class=\"art-button\" type=\"reset\" name=\"btnLimpar\" value=\"Limpar\" />\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"cadastro.jsp\">Cadastro</a> \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"recuperar.jsp\">Recuperar senha</a>  \r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n");
      out.write("                                                          </form></div>\r\n");
      out.write("                                          \r\n");
      out.write("                                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                                              </div>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                              </div>\r\n");
      out.write("                          </div>");
      out.write("\r\n");
      out.write("\t\t");
      out.write("<div class=\"art-block\">\r\n");
      out.write("                              <div class=\"art-block-tl\"></div>\r\n");
      out.write("                              <div class=\"art-block-tr\"></div>\r\n");
      out.write("                              <div class=\"art-block-bl\"></div>\r\n");
      out.write("                              <div class=\"art-block-br\"></div>\r\n");
      out.write("                              <div class=\"art-block-tc\"></div>\r\n");
      out.write("                              <div class=\"art-block-bc\"></div>\r\n");
      out.write("                              <div class=\"art-block-cl\"></div>\r\n");
      out.write("                              <div class=\"art-block-cr\"></div>\r\n");
      out.write("                              <div class=\"art-block-cc\"></div>\r\n");
      out.write("                              <div class=\"art-block-body\">\r\n");
      out.write("                                          <div class=\"art-blockheader\">\r\n");
      out.write("                                              <div class=\"l\"></div>\r\n");
      out.write("                                              <div class=\"r\"></div>\r\n");
      out.write("                                              <h3 class=\"t\">Boletim Informativo</h3>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                                          <div class=\"art-blockcontent\">\r\n");
      out.write("                                              <div class=\"art-blockcontent-body\">\r\n");
      out.write("                                                          <div><form method=\"get\" id=\"newsletterform\" action=\"javascript:void(0)\">\r\n");
      out.write("                                                          <input type=\"text\" value=\"\" name=\"email\" id=\"s\" style=\"width: 95%;\" />\r\n");
      out.write("                                                          <span class=\"art-button-wrapper\">\r\n");
      out.write("                                                          \t<span class=\"art-button-l\"> </span>\r\n");
      out.write("                                                          \t<span class=\"art-button-r\"> </span>\r\n");
      out.write("                                                          \t<input class=\"art-button\" type=\"submit\" name=\"search\" value=\"Subscribe\" />\r\n");
      out.write("                                                          </span>\r\n");
      out.write("                                                          \r\n");
      out.write("                                                          </form></div>\r\n");
      out.write("                                          \r\n");
      out.write("                                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                                              </div>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                              </div>\r\n");
      out.write("                          </div>");
      out.write("\t\t\t\t\t\r\n");
      out.write("\t\t\t\t");
      out.write("<div class=\"art-block\">\r\n");
      out.write("                              <div class=\"art-block-tl\"></div>\r\n");
      out.write("                              <div class=\"art-block-tr\"></div>\r\n");
      out.write("                              <div class=\"art-block-bl\"></div>\r\n");
      out.write("                              <div class=\"art-block-br\"></div>\r\n");
      out.write("                              <div class=\"art-block-tc\"></div>\r\n");
      out.write("                              <div class=\"art-block-bc\"></div>\r\n");
      out.write("                              <div class=\"art-block-cl\"></div>\r\n");
      out.write("                              <div class=\"art-block-cr\"></div>\r\n");
      out.write("                              <div class=\"art-block-cc\"></div>\r\n");
      out.write("                              <div class=\"art-block-body\">\r\n");
      out.write("                                          <div class=\"art-blockheader\">\r\n");
      out.write("                                              <div class=\"l\"></div>\r\n");
      out.write("                                              <div class=\"r\"></div>\r\n");
      out.write("                                              <h3 class=\"t\">Informaç&otilde;es de Contato</h3>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                                          <div class=\"art-blockcontent\">\r\n");
      out.write("                                              <div class=\"art-blockcontent-body\">\r\n");
      out.write("                                                          <div>\r\n");
      out.write("                                                                <img src=\"images/contact.jpg\" alt=\"an image\" style=\"margin: 0 auto;display:block;width:95%\" />\r\n");
      out.write("                                                          <br />\r\n");
      out.write("                                                          <b>Decora Casa e Companhia</b><br />\r\n");
      out.write("                                                          Sao José dos Campos-SP<br />\r\n");
      out.write("                                                          Email: <a href=\"mailto:info@company.com\">info@company.com</a><br />\r\n");
      out.write("                                                          <br />\r\n");
      out.write("                                                          Telefone (12) 3965-7890 <br />\r\n");
      out.write("                                                          Fax: (12) 3965-7890\r\n");
      out.write("                                                          </div>\r\n");
      out.write("                                          \r\n");
      out.write("                                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                                              </div>\r\n");
      out.write("                                          </div>\r\n");
      out.write("                          \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                              </div>\r\n");
      out.write("                          </div>");
      out.write("\t\t\t\t\t\r\n");
      out.write("                            \r\n");
      out.write("                            <div class=\"cleared\"></div>\r\n");
      out.write("\t\t\t\t\t\t</div>");
      out.write("\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t<div class=\"cleared\"></div>\r\n");
      out.write("\t\t\t\t\t<div class=\"art-footer\">\r\n");
      out.write("                    <div class=\"art-footer-t\"></div>\r\n");
      out.write("\t\t\t\t\t");
      out.write(" <div class=\"art-footer-body\">\r\n");
      out.write("                         <a href=\"#\" class=\"art-rss-tag-icon\" title=\"RSS\"></a>\r\n");
      out.write("                        <div class=\"art-footer-text\">\r\n");
      out.write("                            <p><a href=\"#\">Link1</a> | <a href=\"#\">Link2</a> | <a href=\"#\">Link3</a></p>\r\n");
      out.write("                            <p>Copyright &copy; 2012. Todos os direitos reservados.</p>\r\n");
      out.write("                        </div>\r\n");
      out.write("                \t\t<div class=\"cleared\"></div>\r\n");
      out.write("                    </div>");
      out.write("\r\n");
      out.write("                   \r\n");
      out.write("                </div>\r\n");
      out.write("\t\t\t\t\t<div class=\"cleared\"></div>\r\n");
      out.write("\t\t\r\n");
      out.write("           \r\n");
      out.write("            \r\n");
      out.write("             \r\n");
      out.write("           \r\n");
      out.write("\t\t\r\n");
      out.write("\t\t\t</div>\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\t<div class=\"cleared\"></div>\r\n");
      out.write("        <p class=\"art-page-footer\"><a href=\"http://prorfessorleonardo2.bogspot.com/\">Web Template</a> criado com arte.</p>\r\n");
      out.write("        </div>\r\n");
      out.write("    </body>\r\n");
      out.write("</html>\r\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
