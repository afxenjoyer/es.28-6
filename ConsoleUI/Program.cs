using CorsoLibrary;

List<Corso> corsi = new List<Corso>();

int scelta = -1;
while (scelta != 0)
{
    Console.WriteLine("1|Aggiungi un corso");
    Console.WriteLine("2|Seleziona un corso");
    Console.WriteLine("3|Elenca i corsi");
    Console.WriteLine("0|Esci dal programma");

    Console.WriteLine("Inserisci la tua scelta");
    if (!int.TryParse(Console.ReadLine(), out scelta))
    {
        scelta = -1;
    }

    switch (scelta)
    {
        case 1:
            Console.WriteLine("Inserisci il nome del corso");
            string nomeCorso = Console.ReadLine();

            int numEdizione;
            Console.WriteLine("Inserisci l'edizione del corso");
            while (!int.TryParse(Console.ReadLine(), out numEdizione))
            {
                Console.WriteLine("ERRORE: L'input non corrisponde ad un numero");
            }

            corsi.Add(new Corso(nomeCorso, numEdizione));
            Console.WriteLine("Il corso è stato aggiunto");
            break;

        case 2:
            if (corsi.Count == 0)
            {
                Console.WriteLine("Non ci sono corsi da selezionare");
                break;
            }

            for (int i = 0; i < corsi.Count; i++)
            {
                Console.WriteLine($"{i + 1}|{corsi[i]}");
            }

            int indiceCorso = -1;
            int sceltaCorso = -1;
            while (indiceCorso != 0)
            {
                if (sceltaCorso == 0)
                {
                    sceltaCorso = -1;
                    break;
                }

                Console.WriteLine("Inserisci il numero del corso da selezionare");
                if (!int.TryParse(Console.ReadLine(), out indiceCorso))
                {
                    indiceCorso = -1;
                }

                if (indiceCorso-1 < 0 || indiceCorso-1 >= corsi.Count)
                {
                    Console.WriteLine("Il numero inserito non corrisponde a nessun corso nell'elenco");
                }
                else
                {
                    indiceCorso = indiceCorso - 1;
                    Console.WriteLine("Hai selezionato il corso n°{0}", indiceCorso+1);
                    while (sceltaCorso != 0)
                    {
                        Console.WriteLine($"Menù Principale --> {corsi[indiceCorso]}");
                        Console.WriteLine("1|Aggiungi una lezione al corso");
                        Console.WriteLine("2|Elenca le lezioni del corso");
                        Console.WriteLine("3|Seleziona una lezione");
                        Console.WriteLine("4|Aggiungi uno studente al corso");
                        Console.WriteLine("5|Elenca gli studenti del corso");
                        Console.WriteLine("0|Ritorna al Menù Principale");

                        if (!int.TryParse(Console.ReadLine(), out sceltaCorso))
                        {
                            scelta = -1;
                        }

                        switch (sceltaCorso)
                        {
                            case 1:
                                Console.WriteLine("Inserisci la descrizione della lezione");
                                string descrizione = Console.ReadLine();

                                DateTime dataCorso;
                                Console.WriteLine("Inserisci la data del corso");
                                while (!DateTime.TryParse(Console.ReadLine(), out dataCorso))
                                {
                                    Console.WriteLine("ERRORE: L'input non corrisponde ad una data");
                                }

                                DateTime oraInizioCorso;
                                Console.WriteLine("Inserisci l'ora d'inizio del corso");
                                while (!DateTime.TryParse(Console.ReadLine(), out oraInizioCorso))
                                {
                                    Console.WriteLine("ERRORE: L'input non corrisponde ad un'ora");
                                }

                                TimeSpan durataCorso;
                                Console.WriteLine("Inserisci la durata del corso");
                                while (!TimeSpan.TryParse(Console.ReadLine(), out durataCorso))
                                {
                                    Console.WriteLine("ERRORE: L'input non corrisponde ad una durata");
                                }

                                Console.WriteLine("Inserisci il nome della docente");
                                string nomeDocente = Console.ReadLine();

                                Console.WriteLine("Inserisci il cognome della docente");
                                string cognomeDocente = Console.ReadLine();

                                Console.WriteLine("Inserisci il titolo di studio della docente");
                                string titoloStudioDocente = Console.ReadLine();

                                int capienzaAula;
                                Console.WriteLine("Inserisci la capienza dell'aula");
                                while (!int.TryParse(Console.ReadLine(), out capienzaAula))
                                {
                                    Console.WriteLine("ERRORE: L'input non corrisponde ad un numero");
                                }

                                Console.WriteLine("Inserisci il nome dell'aula");
                                string nomeAula = Console.ReadLine();

                                var docenteAssegnato = new Docente(nomeDocente, cognomeDocente, titoloStudioDocente);
                                var aulaAssegnata = new Aula(capienzaAula, nomeAula);
                                corsi[indiceCorso].AggiungiLezione(new Lezione
                                    (descrizione, dataCorso, oraInizioCorso, durataCorso, 
                                        docenteAssegnato, aulaAssegnata, corsi[indiceCorso].Studenti));

                                Console.WriteLine("La lezione è stata aggiunta");
                                break;
                            case 2:
                                if (corsi[indiceCorso].Lezioni.Count == 0)
                                {
                                    Console.WriteLine("Non ci sono lezioni da elencare");
                                    break;
                                }
                                foreach (var lezione in corsi[indiceCorso].Lezioni)
                                {
                                    Console.WriteLine(lezione);
                                }
                                break;
                            case 3:
                                if (corsi[indiceCorso].Lezioni.Count == 0)
                                {
                                    Console.WriteLine("Non ci sono lezioni da selezionare");
                                    break;
                                }

                                for (int i = 0; i < corsi[indiceCorso].Lezioni.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}|{corsi[indiceCorso].Lezioni[i]}");
                                }

                                int indiceLezione = -1;
                                int sceltaLezione = -1;

                                while (indiceLezione != 0)
                                {
                                    //if (sceltaLezione == 0)
                                    //{
                                    //    sceltaLezione = -1;
                                    //    break;
                                    //}

                                    Console.WriteLine("Inserisci il numero della lezione da selezionare");
                                    if (!int.TryParse(Console.ReadLine(), out indiceLezione))
                                    {
                                        indiceLezione = -1;
                                    }

                                    if (indiceLezione - 1 < 0 || indiceLezione - 1 >= corsi[indiceCorso].Lezioni.Count)
                                    {
                                        Console.WriteLine("Il numero inserito non corrisponde a nessuna lezione nell'elenco");
                                    }
                                    else
                                    {
                                        indiceLezione = indiceLezione - 1;
                                        Console.WriteLine("Hai selezionato la lezione n°{0}", indiceLezione + 1);
                                        while (sceltaLezione != 0)
                                        {
                                            Console.WriteLine
                                                ($"Menù Principale --> {corsi[indiceCorso]} --> {corsi[indiceCorso].Lezioni[indiceLezione]}");
                                            Console.WriteLine("TODO:DA FINIRE");
                                        }
                                    }
                                    
                                }
                                
                                break;
                            case 4:
                                Console.WriteLine("Inserisci il nome dello studente");
                                string nomeStudente = Console.ReadLine();

                                Console.WriteLine("Inserisci il cognome dello studente");
                                string cognomeStudente = Console.ReadLine();

                                int matricolaStudente;
                                Console.WriteLine("Inserisci la matricola dello studente ");
                                while (!int.TryParse(Console.ReadLine(), out matricolaStudente) || matricolaStudente <= 0
                                       || corsi[indiceCorso].MatricolaPresente(matricolaStudente))
                                {
                                    if (corsi[indiceCorso].MatricolaPresente(matricolaStudente))
                                        Console.WriteLine("La matricola è gia presente nella lista");
                                    else
                                        Console.WriteLine("La matricola deve essere un numero positivo maggiore di 0");
                                }

                                corsi[indiceCorso].AggiungiStudente(nomeStudente, cognomeStudente, matricolaStudente);
                                Console.WriteLine("Lo studente è stato aggiunto");
                                break;
                            case 5:
                                if (corsi[indiceCorso].Studenti.Count == 0)
                                {
                                    Console.WriteLine("Non ci sono studenti da elencare");
                                    break;
                                }
                                foreach (var studente in corsi[indiceCorso].Studenti)
                                {
                                    Console.WriteLine(studente);
                                }
                                break;
                            case 0:
                                Console.Write("\n");
                                break;
                            default:
                                Console.WriteLine("ERRORE: L'input non corrisponde a nessuna scelta");
                                break;
                        }
                    }
                }
            }

            break;
        
        case 3:
            if (corsi.Count == 0)
            {
                Console.WriteLine("Non ci sono corsi da elencare");
                break;
            }

            for (int i = 0; i < corsi.Count; i++)
            {
                Console.WriteLine($"{i + 1}|{corsi[i]}");
            }
            break;
        case 0:
            Console.WriteLine("Arrivederci");
            return;
        default:
            Console.WriteLine("ERRORE: L'input non corrisponde a nessuna scelta");
            break;
    }
}