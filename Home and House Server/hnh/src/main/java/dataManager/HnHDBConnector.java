package dataManager;

import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Properties;

import com.mysql.jdbc.Connection;

import entities.User;

public class HnHDBConnector {
	//String base="ec2-52-91-88-255.compute-1.amazonaws.com";
	String base="localhost";
	Connection conn = null;

	public HnHDBConnector(){
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Properties connectionProps = new Properties();
			connectionProps.put("user", "hnh-user");
			connectionProps.put("password", "hnhteam");
			conn = (Connection) DriverManager.getConnection(
					"jdbc:mysql://"+base+":3306/hnh-db",
					connectionProps);
			System.out.println("Database Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		catch (ClassNotFoundException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
	}
	
	public User getUserByUsername(String username){
		User user=null;
		ResultSet rs = getResultsSet("SELECT * FROM users WHERE username='"+
		username+"'");
		if(rs!=null){
			try {
				if(rs.next()){
					return new User(rs.getLong("id"),rs.getString("username"),
					rs.getString("name"),rs.getString("accountType"),
					rs.getString("address"));
				}
				System.out.println(rs.getString("name"));
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}	
		return user;
	}
	
	public User getUserById(long id){
		User user=null;
		ResultSet rs = getResultsSet("SELECT * FROM users WHERE id='"+
		id+"'");
		if(rs!=null){
			try {
				if(rs.next()){
					return new User(rs.getLong("id"),rs.getString("username"),
					rs.getString("name"),rs.getString("accountType"),
					rs.getString("address"));
				}
				System.out.println(rs.getString("name"));
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}	
		return user;
	}
	
	public synchronized ResultSet getResultsSet(String quary){
		Statement stmt = null;
		ResultSet rs = null;

		try {
		    stmt = conn.createStatement();
		    rs = stmt.executeQuery(quary);

		    // or alternatively, if you don't know ahead of time that
		    // the query will be a SELECT...

		    if (stmt.execute(quary)) {
		        rs = stmt.getResultSet();
		    }

		    // Now do something with the ResultSet ....
		}
		catch (SQLException ex){
		    // handle any errors
		    System.out.println("SQLException: " + ex.getMessage());
		    System.out.println("SQLState: " + ex.getSQLState());
		    System.out.println("VendorError: " + ex.getErrorCode());
		}
		return rs;
	}
	
	
}
