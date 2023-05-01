package com.example.app_my_buddy;

import java.util.ArrayList;
import java.util.List;

import android.net.Uri;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class Tela13 extends Activity {

	ListView lista;
	ArrayAdapter<String> adapter;
	ArrayList<String> arrayList;
	String classe, id;
	RadioGroup categoria;
	RadioButton r0, r1, r2, r3;
	ProdutoDAO db= new ProdutoDAO(this);
	ImageView imgview;
	String caminho;
	int SELECT_PICTURE = 200;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_tela13);
		
		final EditText nometxt = (EditText) findViewById(R.id.editText1);
		final EditText precotxt = (EditText) findViewById(R.id.editText2);
		final EditText idtxt = (EditText) findViewById(R.id.editText3);
		categoria = (RadioGroup) findViewById(R.id.radioGroup1);
		r0 = (RadioButton) findViewById(R.id.radio0);
		r1 = (RadioButton) findViewById(R.id.radio1);
		r2 = (RadioButton) findViewById(R.id.radio2);
		r3 = (RadioButton) findViewById(R.id.radio3);
		final Button cadastrar = (Button) findViewById(R.id.button1);
		final Button Alterar = (Button) findViewById(R.id.button4);
		final Button Deletar = (Button) findViewById(R.id.button3);
		final Button Listar = (Button) findViewById(R.id.button2);
		final Button imagem = (Button) findViewById(R.id.button5);
		
		categoria.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
			@Override
			public void onCheckedChanged(RadioGroup arg0, int arg1) {
				switch (categoria.getCheckedRadioButtonId()) {
		case R.id.radio0:
			classe = "caminha";
			break;

		case R.id.radio1:
			classe = "comedouro";
			break;
			
		case R.id.radio2:
			classe = "roupa";
			break;

		case R.id.radio3:
			classe = "brinquedinho";
			break;
		default:
			classe = "roupa";
			break;
		}
			}
		});
		cadastrar.setOnClickListener(new Button.OnClickListener() {
			@Override
			public void onClick(View arg0) {
				String nomep = nometxt.getText().toString();
				String precop = precotxt.getText().toString();
				if(nomep.equals("") || precop.equals("") || classe == null){
					Toast.makeText(Tela13.this, "Complete todos os campos", Toast.LENGTH_SHORT).show();
				} else {
				Produtos a = new Produtos();
				a.setNome(nomep);
				a.setPreco(precop);
				a.setClasse(classe);
				db = new ProdutoDAO(Tela13.this);
				db.salvar_produtos(a);

				Toast.makeText(Tela13.this, classe, Toast.LENGTH_SHORT).show();
				}
			}
		});
		
		Alterar.setOnClickListener(new Button.OnClickListener() {
			@Override
		public void onClick(View arg0) {
				String nomep = nometxt.getText().toString();
				String precop = precotxt.getText().toString();
				String idp = idtxt.getText().toString();
				if(nomep.equals("") || precop.equals("") || classe == null){
					Toast.makeText(Tela13.this, "Complete todos os campos", Toast.LENGTH_SHORT).show();
				} else if(idp.equals("") || idp.equals("0")) {
					Toast.makeText(Tela13.this, "Insira um código válido", Toast.LENGTH_SHORT).show();
				} else {
				Produtos a = new Produtos();
				a.setId(Integer.parseInt(id));
				a.setNome(nometxt.getText().toString());
				a.setClasse(classe);
				db= new ProdutoDAO(Tela13.this);
				db.alterar_produtos(a);
				listarProdutos();
				Toast.makeText(Tela13.this, "Alterado", Toast.LENGTH_SHORT).show();
				}
			}
		});
		
		Listar.setOnClickListener(new Button.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				listarProdutos();
			}
		});
		
		lista.setOnItemClickListener(new AdapterView.OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int position,
					long arg3) {
				String conteudo = (String) 
				lista.getItemAtPosition(position);
				String palavra[] = conteudo.split(" - ");
				id = palavra[0];
				idtxt.setText(palavra[0]);
				nometxt.setText(palavra[2]);
				if (palavra[1].equals("caminha")) {
					r0.toggle();
				} else if (palavra[1].equals("comedouro")) {
					r1.toggle();
				} else if (palavra[1].equals("roupa")) {
					r2.toggle();
				} else {
					r3.toggle();
				}
			}
		});
		try {
			Bundle bundle = getIntent().getExtras();
			String nomein = bundle.getString("nome");
			String classein = bundle.getString("classe");
			int idin = bundle.getInt("id");
			nometxt.setText(nomein);
			if (classein.equals("caminha")) {
				r0.setChecked(true);
			} else if(classein.equals("comedouro")){
				r1.setChecked(true);
			} else if(classein.equals("roupa")){
				r2.setChecked(true);
			} else {
				r3.setChecked(true);
			}
			idtxt.setText(String.valueOf(idin));
		} catch (Exception e) {
			// TODO: handle exception
		}
		
		imgview = (ImageView) findViewById(R.id.imageView1);
		imgview.setImageResource(0);
		imgview.setVisibility(View.GONE);

		imagem.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				imageChooser();
			}
		});
	}

	void imageChooser() {

		Intent i = new Intent();
		i.setType("image/*");
		i.setAction(Intent.ACTION_GET_CONTENT);
		startActivityForResult(Intent.createChooser(i, "Select Picture"),
				SELECT_PICTURE);
	}

	public void onActivityResult(int requestCode, int resultCode, Intent data) {
		super.onActivityResult(requestCode, resultCode, data);

		if (resultCode == RESULT_OK) {

			if (requestCode == SELECT_PICTURE) {

				Uri selectedImageUri = data.getData();
				if (null != selectedImageUri) {

					caminho = selectedImageUri.toString();
					imgview.setImageURI(selectedImageUri);
					imgview.setVisibility(View.VISIBLE);
				}
			}
		}

	}
	
	public void listarProdutos() {
		List<Produtos> produtos = db.listaProdutos();
		arrayList = new ArrayList<String>();
		adapter = new ArrayAdapter<String>(Tela13.this,
				android.R.layout.simple_list_item_1, arrayList);
		lista.setAdapter(adapter);
		for (Produtos a : produtos) {
			arrayList.add(a.getId() + " - " + a.getClasse() + " - "
					+ a.getNome());
			adapter.notifyDataSetChanged();
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.tela13, menu);
		return true;
	}

}
