using System;

public class Zpracovani
{
	public static void Zpracuj(int number)
	{
		string state = "";
		bool valid = true;
		switch (number)
		{
			case < 0 and <= 019:
				state = "USA + Kanada";
				break;

			case <= 020 and <= 059:
				valid = false;
				break;

			case <= 060 and <= 99:
				state = "USA + Kanada";
				break;

			case <= 300 and <= 379:
				state = "Francie";
				break;

			case 380:
				state = "Bulharsko";
				break;

			case 383:
				state = "Slovinsko";
				break;

			case 385:
				state = "Chorvatsko";
				break;

			case 387:
				state = "Bosna";
				break;

			case <= 400 and <= 440:
				state = "Německo";
				break;

			case <= 450 and <= 459:
				state = "Japonsko";
				break;

			case <= 460 and <= 469:
				state = "Rusko";
				break;

			case 470:
				state = "Kyrgyzstán";
				break;

			case 471:
				state = "Tchaj-wan";
				break;

			case 474:
				state = "Estonsko";
				break;

			case 475:
				state = "Lotyšsko";
				break;

			case 476:
				state = "Ázerbajdžán";
				break;

			case 477:
				state = "Litva";
				break;

			case 478:
				state = "Uzbekistán";
				break;

			case 479:
				state = "Srí Lanka";
				break;

			case 480:
				state = "Filipíny";
				break;

			case 481:
				state = "Bělorusko";
				break;

			case 482:
				state = "Ukrajina";
				break;

			case 484:
				state = "Moldávie";
				break;

			case 485:
				state = "Arménie";
				break;

			case 486:
				state = "Gruzie";
				break;

			case 487:
				state = "Kazachstán";
				break;

			case 489:
				state = "Hongkong";
				break;

			case <= 500 and <= 509:
				state = "Velká Británie";
				break;

			case <= 520 and <= 521:
				state = "Řecko";
				break;

			case 528:
				state = "Libanon";
				break;

			case 529:
				state = "Kypr";
				break;

			case 531:
				state = "Makedonie";
				break;

			case 535:
				state = "Malta";
				break;

			case 539:
				state = "Irsko";
				break;

			case <= 540 and <= 549:
				state = "Belgie + Lucembursko";
				break;

			case 560:
				state = "Portugalsko";
				break;

			case 569:
				state = "Island";
				break;

			case 570:
				state = "Dánsko";
				break;

			case 590:
				state = "Polsko";
				break;

			case 594:
				state = "Rumunsko";
				break;

			case 599:
				state = "Maďarsko";
				break;

			case <= 600 and <= 601:
				state = "Jižní Afrika";
				break;

			case 603:
				state = "Ghana";
				break;

			case 604:
				state = "Senegal";
				break;

			case 608:
				state = "Bahrajn";
				break;

			case 609:
				state = "Mauricius";
				break;

			case 611:
				state = "Maroko";
				break;

			case 613:
				state = "Alžírsko";
				break;

			case 616:
				state = "Keňa";
				break;

			case 619:
				state = "Tunisko";
				break;

			case 621:
				state = "Sýrie";
				break;

			case 622:
				state = "Egypt";
				break;

            case 624:
				state = "Lýbie";
				break;

			case 625:
				state = "Jordánsko";
				break;

            case 626:
				state = "Írán";
				break;

            case 627:
				state = "Kuvajt";
				break;

            case 628:
				state = "Saudská Arábie";
				break;

            case 629:
				state = "Spojené arabské emiráty";
				break;

            case <= 640 and <= 649:
				state = "Finsko";
				break;

            case <= 690 and <= 699:
				state = "Čína";
				break;

            case <= 700 and <= 709:
				state = "Norsko";
				break;

            case 729:
				state = "Izrael";
				break;

            case <= 730 and <= 739:
				state = "Švédsko";
				break;

            case 740:
				state = "Guatemala";
				break;

            case 741:
				state = "Salvador";
				break;

            case 742:
				state = "Honduras";
				break;

            case 743:
				state = "Kostarika";
				break;

            case 744:
				state = "Nicaragua";
				break;

            case 745:
				state = "Panama";
				break;

            case 746:
				state = "Dominikánská republika";
				break;

            case 750:
				state = "Mexiko";
				break;

            case <= 754 and <= 755:
				state = "Kanada";
				break;

            case 759:
				state = "Venezuela";
				break;

            case <= 760 and <= 769:
				state = "Švýcarsko";
				break;

            case 770:
				state = "Kolumbie";
				break;

            case 773:
				state = "Uruguay";
				break;

            case 775:
				state = "Peru";
				break;

            case 777:
				state = "Bolívie";
				break;

            case 779:
				state = "Argentina";
				break;

            case 780:
				state = "Chile";
				break;

            case 784:
				state = "Paraguay";
				break;

            case 786:
				state = "Ekvádor";
				break;

            case 789:
				state = "Brazílie";
				break;

            case 790:
				state = "Norsko";
					break;

            case <= 800 and <= 839:
				state = "Itálie";
				break;

			case <= 840 and <= 849:
				state = "Španělsko";
				break;

			case 850:
				state = "Kuba";
				break;

			case 858:
				state = "Slovensko";
				break;

			case 859:
				state = "Česko";
				break;

			case 860:
				state = "Srbsko/Černá Hora";
				break;

			case 865:
				state = "Mongolsko";
				break;

			case 867:
				state = "Severní Korea";
				break;

			case 869:
				state = "Turecko";
				break;

			case  <= 870 and <= 879:
				state = "Nizozemsko";
				break;

			case 880:
				state = "Jižní Korea";
				break;

			case 884:
				state = "Kambodža";
				break;

			case 885:
				state = "Thajsko";
				break;

			case 888:
				state = "Singapur";
				break;

			case 890:
				state = "Indie";
				break;

			case 893:
				state = "Vietnam";
				break;

			case 896:
				state = "Pákistán";
				break;

			case 899:
				state = "Indonésie";
				break;

			case <= 900 and <= 919:
				state = "Rakousko";
				break;

			case <= 930 and <= 939:
				state = "Austrálie";
				break;

			case <= 940 and <= 949:
				state = "Nový Zéland";
				break;

			case < 955:
				state = "Malajsie";
				break;

			case 958:
				state = "Makao";
				break;

			case < 958:
				valid = false;
				break;

			default:
				valid = false;
				break;
        }

		if (valid == true)
		{
			MessageBox.Show("Země původu produktu: " + state, "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		else
		{
			MessageBox.Show("Kód není platnej, ale můžeš zkusit zadat jinej.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
