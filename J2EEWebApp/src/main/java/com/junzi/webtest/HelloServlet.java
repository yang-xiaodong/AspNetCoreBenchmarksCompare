package com.junzi.webtest;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class HelloServlet extends HttpServlet {
	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException, ServletException {
		// set content type
		response.setContentType("text/html");
		// write html page
		PrintWriter out = response.getWriter();
		out.print("<HTML><HEAD></HEAD><BODY>Hello World!</BODY></HTML>");
		out.close();
	}
}