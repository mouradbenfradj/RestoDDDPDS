package com.example.lenovog580.restoappnew;

import android.app.Activity;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;


public class MainActivity extends ActionBarActivity {

    EditText etResponse;
    TextView tvIsConnected;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // get reference to the views
        etResponse = (EditText) findViewById(R.id.etResponse);
        tvIsConnected = (TextView) findViewById(R.id.tvIsConnected);

        // check if you are connected or not
        if(isConnected()){
            tvIsConnected.setBackgroundColor(0xFF00CC00);
            tvIsConnected.setText("You are conncted");
        }
        else{
            tvIsConnected.setText("You are NOT conncted");
        }
        // call AsynTask to perform network operation on separate thread
        // Serveur Json Data
        // ----------------------------------------------------------------
        new HttpAsyncTask().execute("http://hmkcode.appspot.com/rest/controller/get.json");

    }

// Get Function Data From Json Data Server ------------------------------------------------
    public static String GET(String url){
        InputStream inputStream = null;
        String result = "";
        try {
            // create HttpClient
            HttpClient httpclient = new DefaultHttpClient();

            // make GET request to the given URL
            HttpResponse httpResponse = httpclient.execute(new HttpGet(url));

            // receive response as inputStream
            inputStream = httpResponse.getEntity().getContent();

            // convert inputstream to string
            if(inputStream != null)
                result = convertInputStreamToString(inputStream);
            else
                result = "Did not work!";

        } catch (Exception e) {
            Log.d("InputStream", e.getLocalizedMessage());
        }
        return result;
    }

    // convert input stream to string using convertInputStreamToString() helper method -----------
    private static String convertInputStreamToString(InputStream inputStream) throws IOException {
        BufferedReader bufferedReader = new BufferedReader( new InputStreamReader(inputStream));
        String line = "";
        String result = "";
        while((line = bufferedReader.readLine()) != null)
            result += line;

        inputStream.close();
        return result;
    }

    //----------------------------------- Test Network connexion ----------------------
    public boolean isConnected(){
        ConnectivityManager connMgr = (ConnectivityManager) getSystemService(Activity.CONNECTIVITY_SERVICE);
        NetworkInfo networkInfo = connMgr.getActiveNetworkInfo();
        if (networkInfo != null && networkInfo.isConnected())
            return true;
        else
            return false;
    }

    //----------------------------------- BackGround task ----------------------
    private class HttpAsyncTask extends AsyncTask<String, Void, String> {
        @Override
        protected String doInBackground(String... urls) {

            return GET(urls[0]);
        }

        //------------- onPostExecute displays the results of the AsyncTask ---------------------
        @Override
        protected void onPostExecute(String result) {
            Toast.makeText(getBaseContext(), "Received!", Toast.LENGTH_LONG).show();
            //etResponse.setText(result);

            try {


                JSONObject json = new JSONObject(result);

                String str = "";

                JSONArray articles = json.getJSONArray("articleList");
                str += "articles length = "+json.getJSONArray("articleList").length();
                str += "\n--------\n";
                str += "names: "+articles.getJSONObject(0).names();
                str += "\n--------\n";
                str += "url: "+articles.getJSONObject(0).getString("url");
                str += "\n--------\n";
                str += "\n--------\n";
                str += "Names: "+articles.getJSONObject(1).names();
                str += "\n--------\n";
                str += "Title: "+articles.getJSONObject(1).getString("title");
                str += "\n--------\n";
                str += "Url: "+articles.getJSONObject(1).getString("url");
                str += "\n--------\n";
                str += "Categories: "+articles.getJSONObject(1).getString("categories");
                str += "\n--------\n";
                str += "Tags: "+articles.getJSONObject(1).getString("tags");


                etResponse.setText(str);
                //etResponse.setText(json.toString(1));

                String[] myItems = {articles.getJSONObject(0).getString("tags"), "Green", "Purple", "Red"}; // Build Adapter
                String[] myItems2 = {articles.getJSONObject(1).getString("title"), articles.getJSONObject(1).getString("url"), articles.getJSONObject(1).getString("categories"), articles.getJSONObject(1).getString("tags")}; // Build Adapter
// TODO: CHANGE THE [[ to a less than, ]] to greater than.
                ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(getBaseContext(), R.layout.da_item2, myItems2);
                ArrayAdapter<String> adapter = new ArrayAdapter<String>(getBaseContext(), R.layout.da_item, myItems);
                ListView list = (ListView) findViewById(R.id.listViewMain);
                ListView list2 = (ListView) findViewById(R.id.listViewMain2);
                list.setAdapter(adapter);
                list2.setAdapter(adapter2);
            } catch (JSONException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
        }

    }

    private void populateListView() {
// Create list of items
        String[] myItems = {"Blue", "Green", "Purple", "Red"}; // Build Adapter
// TODO: CHANGE THE [[ to a less than, ]] to greater than.
        ArrayAdapter<String> adapter = new ArrayAdapter<String>( this, R.layout.da_item, myItems);
                ListView list = (ListView) findViewById(R.id.listViewMain);
        list.setAdapter(adapter);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
