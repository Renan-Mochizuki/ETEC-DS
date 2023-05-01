package com.example.app_my_buddy;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import com.example.app_my_buddy.Tela04.AdapImgc;
import com.example.app_my_buddy.Tela04.AdapImgg;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.graphics.Typeface;
import android.net.Uri;
import android.os.Bundle;
import android.util.Base64;
import android.view.Menu;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class Tela06 extends Activity {
	
	ArrayList<String> arrayList;
	ListView lista1, lista2, lista3, lista4;
	ProdutoDAO db = new ProdutoDAO(this);
	
	public static String[] imgca, imgco, imgro, imgbr;
	public static String[] nomeca, precoca, nomeco, precoco, nomero, precoro, nomebr, precobr;
	public static int[] idca, idco, idro, idbr;
	int ica = 0, ico = 0, iro = 0, ibr = 0, sizeca = 0, sizeco = 0, sizero = 0, sizebr = 0;
	Bundle dados = new Bundle();
	String tipo;
	Uri[] convertidoc, convertidog;
	TextView msgca, msgco, msgro, msgbr;
	View view;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.activity_tela06);
		
		lista1 = (ListView) findViewById(R.id.listview1);
		lista2 = (ListView) findViewById(R.id.listview2);
		lista3 = (ListView) findViewById(R.id.listview3);
		lista4 = (ListView) findViewById(R.id.listview4);
		final Spinner spinner = (Spinner) findViewById(R.id.spinner1);
		final TextView pesquisar = (TextView)findViewById(R.id.textView84);
		final TextView limpar = (TextView)findViewById(R.id.textView85);
		final TextView txtcaminhas = (TextView)findViewById(R.id.textView1);
		final TextView txtcomedouros = (TextView)findViewById(R.id.textView32);
		final TextView txtroupinhas = (TextView)findViewById(R.id.textView33);
		final TextView txtbrinquedos = (TextView)findViewById(R.id.textView34);
//		final Button animais = (Button) findViewById(R.id.button1);
//		final Button produtosred = (Button) findViewById(R.id.button2);
//		final Button oq_e = (Button) findViewById(R.id.button3);
//		final Button doacao = (Button) findViewById(R.id.button4);
//		final Button home = (Button) findViewById(R.id.button5);
		final Button cad = (Button) findViewById(R.id.button1);
		msgca = (TextView) findViewById(R.id.textView11);
		msgco = (TextView) findViewById(R.id.textView12);
		msgro = (TextView) findViewById(R.id.textView13);
		msgbr = (TextView) findViewById(R.id.textView14);
		// final LinearLayout l_oq_e = (LinearLayout) findViewById(R.id.linear_btn_oq_e);

		// Font
		Typeface font = Typeface.createFromAsset(getAssets(), "lemonmelon.ttf");
		Typeface regencie = Typeface.createFromAsset(getAssets(), "regencie1.ttf");
//		animais.setTypeface(font);
//		produtosred.setTypeface(font);
//		oq_e.setTypeface(font);
//		doacao.setTypeface(font);
//		home.setTypeface(font);
		msgca.setTypeface(regencie);
		msgco.setTypeface(regencie);
		msgro.setTypeface(regencie);
		msgbr.setTypeface(regencie);
		/*
		home.setOnClickListener(new Button.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				Intent i1 = new Intent(Tela06.this, Tela02.class);
				startActivity(i1);

			}
		});
		
		animais.setOnClickListener(new Button.OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				Intent i1=new Intent(Tela06.this,Tela04.class);
				startActivity(i1);
				
			}
		});
		
		produtosred.setOnClickListener(new Button.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				Intent i1 = new Intent(Tela06.this, Tela06.class);
				startActivity(i1);

			}
		});

		oq_e.setOnClickListener(new Button.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				Intent i1 = new Intent(Tela06.this, Tela03.class);
				startActivity(i1);

			}
		});

		doacao.setOnClickListener(new Button.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				Intent i1 = new Intent(Tela06.this, Tela05.class);
				startActivity(i1);

			}
		});
		*/
		// Início do código da pesquisa
		 String[] categoria = new String[]{
                "Escolha uma categoria",
                "Caminhas",
                "Comedouros",
                "Roupinhas",
                "Brinquedos"
        };
		 List<String> categoriaList = new ArrayList<String>(Arrays.asList(categoria));
        ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(
       		 this, android.R.layout.simple_dropdown_item_1line,categoriaList){
       	 @Override
            public boolean isEnabled(int position){
                    return position != 0;
            } @Override
            public View getDropDownView(
                    int position, View convertView, ViewGroup parent) {
           	 
                    View view = super.getDropDownView(position, convertView, parent);
                    TextView textView = (TextView) view;
                    if(position == 0){
                            textView.setTextColor(Color.GRAY);
                    }
                    else {textView.setTextColor(Color.BLACK); }
                    return view;
            }
        };
        spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_dropdown_item_1line);
        spinner.setAdapter(spinnerArrayAdapter);
        // Caixa de pesquisa
     		pesquisar.setOnClickListener(new View.OnClickListener() {

     			@Override
     			public void onClick(View arg0) {
     				String pesquisar = spinner.getSelectedItem().toString();
     				
     				if (pesquisar.equals("Caminhas")) {
     					lista1.setVisibility(View.VISIBLE);
     					txtcaminhas.setVisibility(View.VISIBLE);
     					lista2.setVisibility(View.GONE);
     					txtcomedouros.setVisibility(View.GONE);
     					lista3.setVisibility(View.GONE);
     					txtroupinhas.setVisibility(View.GONE);
     					lista4.setVisibility(View.GONE);
     					txtbrinquedos.setVisibility(View.GONE);
     					
     				} else if (pesquisar.equals("Comedouros")) {
     					lista1.setVisibility(View.GONE);
     					txtcaminhas.setVisibility(View.GONE);
     					lista2.setVisibility(View.VISIBLE);
     					txtcomedouros.setVisibility(View.VISIBLE);
     					lista3.setVisibility(View.GONE);
     					txtroupinhas.setVisibility(View.GONE);
     					lista4.setVisibility(View.GONE);
     					txtbrinquedos.setVisibility(View.GONE);

     				} else if (pesquisar.equals("Roupinhas")) {
     					lista1.setVisibility(View.GONE);
     					txtcaminhas.setVisibility(View.GONE);
     					lista2.setVisibility(View.GONE);
     					txtcomedouros.setVisibility(View.GONE);
     					lista3.setVisibility(View.VISIBLE);
     					txtroupinhas.setVisibility(View.VISIBLE);
     					lista4.setVisibility(View.GONE);
     					txtbrinquedos.setVisibility(View.GONE);

     				} else if (pesquisar.equals("Brinquedos")) {
     					lista1.setVisibility(View.GONE);
     					txtcaminhas.setVisibility(View.GONE);
     					lista2.setVisibility(View.GONE);
     					txtcomedouros.setVisibility(View.GONE);
     					lista3.setVisibility(View.GONE);
     					txtroupinhas.setVisibility(View.GONE);
     					lista4.setVisibility(View.VISIBLE);
     					txtbrinquedos.setVisibility(View.VISIBLE);
     				} else {
     					Toast.makeText(Tela06.this, "Selecione uma opção para filtrar", Toast.LENGTH_SHORT).show();
     				}
     				Toast.makeText(getApplicationContext(), "Filtrado", Toast.LENGTH_SHORT).show();
     			}
     		});
     		limpar.setOnClickListener(new View.OnClickListener() {
     			
     			@Override
     			public void onClick(View arg0) {
     				// TODO Auto-generated method stub
     				lista1.setVisibility(View.VISIBLE);
     				txtcaminhas.setVisibility(View.VISIBLE);
     				lista2.setVisibility(View.VISIBLE);
     				txtcomedouros.setVisibility(View.VISIBLE);
     				lista3.setVisibility(View.VISIBLE);
     				txtroupinhas.setVisibility(View.VISIBLE);
     				lista4.setVisibility(View.VISIBLE);
     				txtbrinquedos.setVisibility(View.VISIBLE);
     				Toast.makeText(getApplicationContext(), "Limpo", Toast.LENGTH_SHORT).show();
     			}
     		});
     	// Fim do código da pesquisa
     		
     		List<Produtos> produtos = db.listaProdutos();
    		arrayList = new ArrayList<String>();
    		
    		// Tamanho da array
    		for (Produtos a: produtos) {
    			
    			tipo = a.getClasse().toString();
    			if(tipo.equals("caminha")){
    				sizeca++;
    			} else if(tipo.equals("comedouro")){
    				sizeco++;
    			} else if(tipo.equals("roupa")){
    				sizero++;
    			} else {
    				sizebr++;
    			}
    		}
    		
    		// Define o tamanho das arrays
    		nomeca = new String[sizeca];
    		imgca = new String[sizeca];
    		precoca = new String[sizeca];
    		idca = new int[sizeca];
    		nomeco = new String[sizeco];
    		imgco = new String[sizeco];
    		precoco = new String[sizeco];
    		idco = new int[sizeco];
    		nomero = new String[sizero];
    		imgro = new String[sizero];
    		precoro = new String[sizero];
    		idro = new int[sizero];
    		nomebr = new String[sizebr];
    		imgbr = new String[sizebr];
    		precobr = new String[sizebr];
    		idbr = new int[sizebr];
    		
    		// Define cada valor de atributo do bd para cada array
    		for (Produtos a: produtos) {
    			
    			tipo = a.getClasse().toString();
    			if(tipo.equals("caminha")){
    				idca[ica] = a.getId();
    				nomeca[ica] = a.getNome().toString();
    				precoca[ica] = a.getPreco().toString();
    				imgca[ica] = a.getImagem().toString();
    				ica++;
    			} else if(tipo.equals("comedouro")){
    				idco[ico] = a.getId();
    				nomeco[ico] = a.getNome().toString();
    				precoco[ico] = a.getPreco().toString();
    				imgco[ico] = a.getImagem().toString();
    				ico++;
    			} else if(tipo.equals("roupa")){
    				idro[iro] = a.getId();
    				nomero[iro] = a.getNome().toString();
    				precoro[iro] = a.getPreco().toString();
    				imgro[iro] = a.getImagem().toString();
    				iro++;
    			} else {
    				idbr[ibr] = a.getId();
    				nomebr[ibr] = a.getNome().toString();
    				precobr[ibr] = a.getPreco().toString();
    				imgbr[ibr] = a.getImagem().toString();
    				ibr++;
    			}
    		}
    		
    		exibirMensagem(); 
    		    		
    		// Coloque o adapter na lista
    		AdapImgca objca = new AdapImgca(Tela06.this, imgca, nomeca, precoca);
    		lista1.setAdapter(objca);
    		/*AdapImgco objco = new AdapImgco(Tela06.this, imgco, nomeco, precoco);
    		lista2.setAdapter(objco);
    		AdapImgro objro = new AdapImgro(Tela06.this, imgro, nomero, precoro);
    		lista1.setAdapter(objro);
    		AdapImgbr objbr = new AdapImgbr(Tela06.this, imgbr, nomebr, precobr);
    		lista2.setAdapter(objbr);
    		*/
    		/*
    		ImageView imagema = (ImageView) findViewById(R.id.imageView1);
    		Uri convertido = Uri.parse(imgc[0]);
        	imagema.setImageURI(convertido);
    		*/
    		
    		Bundle bundle = getIntent().getExtras();
    		int usuario = bundle.getInt("usuario");
    		
    		switch (usuario) {
    		case 1: // ADM
    			cad.setVisibility(View.VISIBLE);
    			//l_oq_e.setVisibility(View.GONE);
    			break;
    		default: // Cliente
    			cad.setVisibility(View.GONE);
    			//l_oq_e.setVisibility(View.VISIBLE);
    			break;
    		}

    		cad.setOnClickListener(new View.OnClickListener() {
    			
    			@Override
    			public void onClick(View arg0) {
    				// TODO Auto-generated method stub
    				Intent cad = new Intent(Tela06.this, Tela13.class);
    				startActivity(cad);	
    			}
    		});
    		
    	}
    	
    	// Mensagem caso não houver nenhum animal cadastrado
    	public void exibirMensagem() {
    				try {
    					if(nomeca[0] != null || nomeca[0].equals(" ")){
    						msgca.setVisibility(View.GONE);
    					}
    				} catch (Exception e) {
    					msgca.setVisibility(View.VISIBLE);
    				}
    				try {
    					if(nomeco[0] != null || nomeco[0].equals(" ")){
    						msgco.setVisibility(View.GONE);
    					}
    				} catch (Exception e) {
    					msgco.setVisibility(View.VISIBLE);
    				}	
    				try {
    					if(nomero[0] != null || nomero[0].equals(" ")){
    						msgro.setVisibility(View.GONE);
    					}
    				} catch (Exception e) {
    					msgro.setVisibility(View.VISIBLE);
    				}
    				try {
    					if(nomebr[0] != null || nomebr[0].equals(" ")){
    						msgbr.setVisibility(View.GONE);
    					}
    				} catch (Exception e) {
    					msgbr.setVisibility(View.VISIBLE);
    				}	
    	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.tela06, menu);
		return true;
	}
	// Adapter da lista
		class AdapImgca extends ArrayAdapter<String> {

			@Override
			public long getItemId(int position) {
				return position;
			}
			
			AdapImgca(Context c, String[] imgca, String[] nomeca, String[] precoca){
				super(c, R.layout.produtos, R.id.button5, nomeca);
			}

			@Override
			public View getView(final int position, View convertView, ViewGroup parent) {

				Bundle bundle = getIntent().getExtras();
				int usuario = bundle.getInt("usuario");
				
				switch (usuario) {
				case 1: // ADM
					view = getLayoutInflater().inflate(R.layout.produtos_adm, null);
					break;
				default: // Cliente
					view = getLayoutInflater().inflate(R.layout.produtos, null);
					break;
				}
				
				ImageView imgimagem = (ImageView) view.findViewById(R.id.imageView3);
				TextView txtnome = (TextView) view.findViewById(R.id.textView2);
				TextView txtpreco = (TextView) view.findViewById(R.id.textView3);
				final LinearLayout linear = (LinearLayout) view.findViewById(R.id.linear1);

				Bitmap bitm = StringToBitMap(imgca[position]);
				
				imgimagem.setImageBitmap(bitm);
				
	 //       	convertidoc[position] = Uri.parse(imgc[position]);

				txtnome.setText(nomeca[position]);
				txtpreco.setText(precoca[position]);
				
				switch (usuario) {
				case 1: // ADM
					Button excluir = (Button) view.findViewById(R.id.button2);
					Button alterar = (Button) view.findViewById(R.id.button1);
					excluir.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							AlertDialog.Builder alerta = new AlertDialog.Builder(Tela06.this);
							alerta.setTitle("Excluir esse cadastro?");
							alerta.setMessage("Tem certeza que deseja excluir esse cadastro?");
							alerta.setCancelable(false);
							alerta.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// TODO Auto-generated method stub
									Produtos a = new Produtos();
									a.setId(idca[position]);
									db = new ProdutoDAO(Tela06.this);
									db.delete_produtos(a);
									Toast.makeText(Tela06.this, "Excluído", Toast.LENGTH_SHORT).show();
									linear.setVisibility(View.GONE);
								}
							});
							alerta.setNegativeButton("Não", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// Fechar o alerta
								}
							});
							alerta.show();
						}
					});
					alterar.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							dados.putString("nome", nomeca[position]);
							dados.putString("preco", precoca[position]);
							dados.putString("classe", "caminha");
							dados.putInt("id", idca[position]);
							Intent it = new Intent(Tela06.this, Tela13.class);
							it.putExtras(dados);
							startActivity(it);
						}
					});
					break;
				default: // Cliente
					Button botao = (Button) view.findViewById(R.id.button7);
					botao.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							Toast.makeText(Tela06.this, "Produto adicionado ao carrinho", Toast.LENGTH_SHORT).show();
						}
					});
					break;
				}
				return view;
			}
		}
		class AdapImgco extends ArrayAdapter<String> {

			@Override
			public long getItemId(int position) {
				return position;
			}
			
			AdapImgco(Context c, String[] imgco, String[] nomeco, String[] precoco){
				super(c, R.layout.produtos, R.id.button5, nomeco);
			}

			@Override
			public View getView(final int position, View convertView, ViewGroup parent) {

				Bundle bundle = getIntent().getExtras();
				int usuario = bundle.getInt("usuario");
				
				switch (usuario) {
				case 1: // ADM
					view = getLayoutInflater().inflate(R.layout.produtos_adm, null);
					break;
				default: // Cliente
					view = getLayoutInflater().inflate(R.layout.produtos, null);
					break;
				}
				
				ImageView imgimagem = (ImageView) view.findViewById(R.id.imageView3);
				TextView txtnome = (TextView) view.findViewById(R.id.textView2);
				TextView txtpreco = (TextView) view.findViewById(R.id.textView3);
				final LinearLayout linear = (LinearLayout) view.findViewById(R.id.linear1);

				Bitmap bitm = StringToBitMap(imgco[position]);
				
				imgimagem.setImageBitmap(bitm);
				
	 //       	convertidoc[position] = Uri.parse(imgc[position]);

				txtnome.setText(nomeco[position]);
				txtpreco.setText(precoco[position]);
				
				switch (usuario) {
				case 1: // ADM
					Button excluir = (Button) view.findViewById(R.id.button2);
					Button alterar = (Button) view.findViewById(R.id.button1);
					excluir.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							AlertDialog.Builder alerta = new AlertDialog.Builder(Tela06.this);
							alerta.setTitle("Excluir esse cadastro?");
							alerta.setMessage("Tem certeza que deseja excluir esse cadastro?");
							alerta.setCancelable(false);
							alerta.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// TODO Auto-generated method stub
									Produtos a = new Produtos();
									a.setId(idco[position]);
									db = new ProdutoDAO(Tela06.this);
									db.delete_produtos(a);
									Toast.makeText(Tela06.this, "Excluído", Toast.LENGTH_SHORT).show();
									linear.setVisibility(View.GONE);
								}
							});
							alerta.setNegativeButton("Não", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// Fechar o alerta
								}
							});
							alerta.show();
						}
					});
					alterar.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							dados.putString("nome", nomeco[position]);
							dados.putString("preco", precoco[position]);
							dados.putString("classe", "comedouro");
							dados.putInt("id", idco[position]);
							Intent it = new Intent(Tela06.this, Tela13.class);
							it.putExtras(dados);
							startActivity(it);
						}
					});
					break;
				default: // Cliente
					Button botao = (Button) view.findViewById(R.id.button7);
					botao.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							Toast.makeText(Tela06.this, "Produto adicionado ao carrinho", Toast.LENGTH_SHORT).show();
						}
					});
					break;
				}
				return view;
			}
		}
		class AdapImgro extends ArrayAdapter<String> {

			@Override
			public long getItemId(int position) {
				return position;
			}
			
			AdapImgro(Context c, String[] imgro, String[] nomero, String[] precoro){
				super(c, R.layout.produtos, R.id.button5, nomero);
			}

			@Override
			public View getView(final int position, View convertView, ViewGroup parent) {

				Bundle bundle = getIntent().getExtras();
				int usuario = bundle.getInt("usuario");
				
				switch (usuario) {
				case 1: // ADM
					view = getLayoutInflater().inflate(R.layout.produtos_adm, null);
					break;
				default: // Cliente
					view = getLayoutInflater().inflate(R.layout.produtos, null);
					break;
				}
				
				ImageView imgimagem = (ImageView) view.findViewById(R.id.imageView3);
				TextView txtnome = (TextView) view.findViewById(R.id.textView2);
				TextView txtpreco = (TextView) view.findViewById(R.id.textView3);
				final LinearLayout linear = (LinearLayout) view.findViewById(R.id.linear1);

				Bitmap bitm = StringToBitMap(imgro[position]);
				
				imgimagem.setImageBitmap(bitm);
				
	 //       	convertidoc[position] = Uri.parse(imgc[position]);

				txtnome.setText(nomero[position]);
				txtpreco.setText(precoro[position]);
				
				switch (usuario) {
				case 1: // ADM
					Button excluir = (Button) view.findViewById(R.id.button2);
					Button alterar = (Button) view.findViewById(R.id.button1);
					excluir.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							AlertDialog.Builder alerta = new AlertDialog.Builder(Tela06.this);
							alerta.setTitle("Excluir esse cadastro?");
							alerta.setMessage("Tem certeza que deseja excluir esse cadastro?");
							alerta.setCancelable(false);
							alerta.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// TODO Auto-generated method stub
									Produtos a = new Produtos();
									a.setId(idro[position]);
									db = new ProdutoDAO(Tela06.this);
									db.delete_produtos(a);
									Toast.makeText(Tela06.this, "Excluído", Toast.LENGTH_SHORT).show();
									linear.setVisibility(View.GONE);
								}
							});
							alerta.setNegativeButton("Não", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// Fechar o alerta
								}
							});
							alerta.show();
						}
					});
					alterar.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							dados.putString("nome", nomero[position]);
							dados.putString("preco", precoro[position]);
							dados.putString("classe", "roupa");
							dados.putInt("id", idro[position]);
							Intent it = new Intent(Tela06.this, Tela13.class);
							it.putExtras(dados);
							startActivity(it);
						}
					});
					break;
				default: // Cliente
					Button botao = (Button) view.findViewById(R.id.button7);
					botao.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							Toast.makeText(Tela06.this, "Produto adicionado ao carrinho", Toast.LENGTH_SHORT).show();
						}
					});
					break;
				}
				return view;
			}
		}
		class AdapImgbr extends ArrayAdapter<String> {

			@Override
			public long getItemId(int position) {
				return position;
			}
			
			AdapImgbr(Context c, String[] imgbr, String[] nomebr, String[] precobr){
				super(c, R.layout.produtos, R.id.button5, nomebr);
			}

			@Override
			public View getView(final int position, View convertView, ViewGroup parent) {

				Bundle bundle = getIntent().getExtras();
				int usuario = bundle.getInt("usuario");
				
				switch (usuario) {
				case 1: // ADM
					view = getLayoutInflater().inflate(R.layout.produtos_adm, null);
					break;
				default: // Cliente
					view = getLayoutInflater().inflate(R.layout.produtos, null);
					break;
				}
				
				ImageView imgimagem = (ImageView) view.findViewById(R.id.imageView3);
				TextView txtnome = (TextView) view.findViewById(R.id.textView2);
				TextView txtpreco = (TextView) view.findViewById(R.id.textView3);
				final LinearLayout linear = (LinearLayout) view.findViewById(R.id.linear1);

				Bitmap bitm = StringToBitMap(imgbr[position]);
				
				imgimagem.setImageBitmap(bitm);
				
	 //       	convertidoc[position] = Uri.parse(imgc[position]);

				txtnome.setText(nomebr[position]);
				txtpreco.setText(precobr[position]);
				
				switch (usuario) {
				case 1: // ADM
					Button excluir = (Button) view.findViewById(R.id.button2);
					Button alterar = (Button) view.findViewById(R.id.button1);
					excluir.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							AlertDialog.Builder alerta = new AlertDialog.Builder(Tela06.this);
							alerta.setTitle("Excluir esse cadastro?");
							alerta.setMessage("Tem certeza que deseja excluir esse cadastro?");
							alerta.setCancelable(false);
							alerta.setPositiveButton("Sim", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// TODO Auto-generated method stub
									Produtos a = new Produtos();
									a.setId(idbr[position]);
									db = new ProdutoDAO(Tela06.this);
									db.delete_produtos(a);
									Toast.makeText(Tela06.this, "Excluído", Toast.LENGTH_SHORT).show();
									linear.setVisibility(View.GONE);
								}
							});
							alerta.setNegativeButton("Não", new DialogInterface.OnClickListener() {
								@Override
								public void onClick(DialogInterface arg0, int arg1) {
									// Fechar o alerta
								}
							});
							alerta.show();
						}
					});
					alterar.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							dados.putString("nome", nomebr[position]);
							dados.putString("preco", precobr[position]);
							dados.putString("classe", "brinquedo");
							dados.putInt("id", idbr[position]);
							Intent it = new Intent(Tela06.this, Tela13.class);
							it.putExtras(dados);
							startActivity(it);
						}
					});
					break;
				default: // Cliente
					Button botao = (Button) view.findViewById(R.id.button7);
					botao.setOnClickListener(new View.OnClickListener() {
						@Override
						public void onClick(View arg0) {
							// TODO Auto-generated method stub
							Toast.makeText(Tela06.this, "Produto adicionado ao carrinho", Toast.LENGTH_SHORT).show();
						}
					});
					break;
				}
				return view;
			}
		}

		public Bitmap StringToBitMap(String encodedString) {
		    try {
		        byte[] encodeByte = Base64.decode(encodedString, Base64.DEFAULT);
		        Bitmap bitmap = BitmapFactory.decodeByteArray(encodeByte, 0,
		                encodeByte.length);
		        return bitmap;
		    } catch (Exception e) {
		        e.getMessage();
		        return null;
		    }
		}
		
		

	}