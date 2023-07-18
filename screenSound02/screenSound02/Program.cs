
Album albumDoGunsInRoses = new Album();
albumDoGunsInRoses.Nome = "Use your ilusion I";

Musica musicaGNR = new Musica();
musicaGNR.Nome = "November Rain";
musicaGNR.Duracao = 538;

Musica musicaGNR2 = new Musica();
musicaGNR2.Nome = "Live and Let Die";
musicaGNR2.Duracao = 184;

albumDoGunsInRoses.AdicionarMusica(musicaGNR);
albumDoGunsInRoses.AdicionarMusica(musicaGNR2);

albumDoGunsInRoses.ExibirMusicasDoAlbum();

