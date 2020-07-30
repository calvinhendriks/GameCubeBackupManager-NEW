using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCubeBackupManager
{
    class IsoFileCodes
    {
        private void ParseIsoFile(string path)
        {
            //MessageBox.Show("DEBUG (parseIsoFile): " + fbd1.SelectedPath + @"\" + path);

            GCDiscInfo gCDiscInfo = new GCDiscInfo(path);

            textBoxGameName.Text = gCDiscInfo.getGameName();
            string consoleID = gCDiscInfo.getConsoleId();
            string countryCode = gCDiscInfo.getCountryCode();
            string makerCode = gCDiscInfo.getMakerCode();
            string gameCode = gCDiscInfo.getGameCode();

            textBoxCountryCode.Text = countryCode;

            //GameID = textBoxGameID.Text;
            //textBoxGameID.Text = textBoxGameID.Text;

            textBoxDiscID.Text = gCDiscInfo.getDiscId();

            // ConsoleID
            if (consoleID == "44") //Emulated/Ported/Promotional
            {
                textBoxGameID.Text = "D" + gameCode;
            }
            else if (consoleID == "47") //Gamecube
            {
                textBoxGameID.Text = "G" + gameCode;
            }
            else //GBA-Player Boot CD
            {
                textBoxGameID.Text = "U" + gameCode;
            }

            // CountryCode
            if (countryCode == "45") // USA/NTSC
            {
                textBoxGameID.Text += "E";
            }
            else if (countryCode == "4A") // Japan/NTSC
            {
                textBoxGameID.Text += "J";
            }
            else if (countryCode == "50") // Europe/PAL
            {
                textBoxGameID.Text += "P";
            }
            else //Europe/PAL (Loz Oot (MQ)) ?
            {
                textBoxGameID.Text += "U";
            }

            // MakerCode Original
            if (makerCode == "0A") // Jaleco / Jaleco Entertainment
            {
                textBoxGameID.Text += "0A";
            }
            else if (makerCode == "0B") // Coconuts Japan
            {
                textBoxGameID.Text += "0B";
            }
            else if (makerCode == "0C") // Coconuts Japan / G.X.Media
            {
                textBoxGameID.Text += "0C";
            }
            else if (makerCode == "0D") // Micronet
            {
                textBoxGameID.Text += "0D";
            }
            else if (makerCode == "0E") // Technos
            {
                textBoxGameID.Text += "0E";
            }
            else if (makerCode == "0F") // Mebio Software
            {
                textBoxGameID.Text += "0F";
            }
            else if (makerCode == "0G") // Shouei System
            {
                textBoxGameID.Text += "0G";
            }
            else if (makerCode == "0H") // Starfish
            {
                textBoxGameID.Text += "0H";
            }
            else if (makerCode == "0J") // Mitsui Fudosan / Dentsu
            {
                textBoxGameID.Text += "0J";
            }
            else if (makerCode == "0L") // Warashi Inc.
            {
                textBoxGameID.Text += "0L";
            }
            else if (makerCode == "0M") // Entrtainment Software Publishing
            {
                textBoxGameID.Text += "0M";
            }
            else if (makerCode == "0N") // Nowpro
            {
                textBoxGameID.Text += "0N";
            }
            else if (makerCode == "0P") // Game Village
            {
                textBoxGameID.Text += "0P";
            }
            else if (makerCode == "0Q") // IE Institute
            {
                textBoxGameID.Text += "0Q";
            }
            else if (makerCode == "01") // Nintendo
            {
                textBoxGameID.Text += "01";
            }

            else if (makerCode == "01NK") // Stage Clear Studios
            {
                textBoxGameID.Text += "01NK";
            }
            else if (makerCode == "01PF") // Iron Galaxy Studios
            {
                textBoxGameID.Text += "01PF";
            }
            else if (makerCode == "0103") // Dolores Entertainment
            {
                textBoxGameID.Text += "0103";
            }
            else if (makerCode == "011A") // Anzimuz Games
            {
                textBoxGameID.Text += "011A";
            }
            else if (makerCode == "011D") // Over the Moon
            {
                textBoxGameID.Text += "011D";
            }
            else if (makerCode == "011F") // Finger Gun Games
            {
                textBoxGameID.Text += "011F";
            }
            else if (makerCode == "011X") // Tic Toc Games
            {
                textBoxGameID.Text += "011X";
            }
            else if (makerCode == "012C") // ScrewAttack Games
            {
                textBoxGameID.Text += "012C";
            }
            else if (makerCode == "013A") // Rain Games
            {
                textBoxGameID.Text += "013A";
            }
            else if (makerCode == "013S") // Threaks
            {
                textBoxGameID.Text += "013S";
            }
            else if (makerCode == "0137") // Frogmind
            {
                textBoxGameID.Text += "0137";
            }
            else if (makerCode == "0148") // Log Games
            {
                textBoxGameID.Text += "0148";
            }
            else if (makerCode == "0149") // Utopian World of Sandwiches
            {
                textBoxGameID.Text += "0149";
            }
            else if (makerCode == "015D") // Double 11 Ltd
            {
                textBoxGameID.Text += "015D";
            }
            else if (makerCode == "015V") // Xiness
            {
                textBoxGameID.Text += "015V";
            }
            else if (makerCode == "016J") // Headup Games
            {
                textBoxGameID.Text += "016J";
            }
            else if (makerCode == "016X") // Simogo
            {
                textBoxGameID.Text += "016X";
            }
            else if (makerCode == "0167") // Galaxy Trail
            {
                textBoxGameID.Text += "0167";
            }
            else if (makerCode == "0169") // Klei Entertainment
            {
                textBoxGameID.Text += "0169";
            }
            else if (makerCode == "017C") // Herrero Games
            {
                textBoxGameID.Text += "017C";
            }
            else if (makerCode == "017D") // Nostatic Software, LLC
            {
                textBoxGameID.Text += "017D";
            }
            else if (makerCode == "017T") // Rainy Night Creations
            {
                textBoxGameID.Text += "017T";
            }
            else if (makerCode == "017X") // Blue Isle Studios
            {
                textBoxGameID.Text += "017X";
            }
            else if (makerCode == "017Z") // Team Meat
            {
                textBoxGameID.Text += "017Z";
            }
            else if (makerCode == "0185") // Oddworld Inhabitants
            {
                textBoxGameID.Text += "0185";
            }
            else if (makerCode == "02") // Rocket Games / Ajinomoto / Nintendo
            {
                textBoxGameID.Text += "02";
            }
            else if (makerCode == "03") // Imaginner-Zoom
            {
                textBoxGameID.Text += "03";
            }
            else if (makerCode == "04") // Gray Matter
            {
                textBoxGameID.Text += "04";
            }
            else if (makerCode == "05") // Zamuse
            {
                textBoxGameID.Text += "05";
            }
            else if (makerCode == "06") // Falcom
            {
                textBoxGameID.Text += "06";
            }
            else if (makerCode == "07") // Enix
            {
                textBoxGameID.Text += "07";
            }
            else if (makerCode == "08") // Capcom
            {
                textBoxGameID.Text += "08";
            }
            else if (makerCode == "09") // Hot B Co.
            {
                textBoxGameID.Text += "09";
            }
            else if (makerCode == "1A") // Yanoman
            {
                textBoxGameID.Text += "1A";
            }
            else if (makerCode == "1C") // Tecmo Products
            {
                textBoxGameID.Text += "1C";
            }
            else if (makerCode == "1D") // Japan Glary Business
            {
                textBoxGameID.Text += "1D";
            }
            else if (makerCode == "1E") // Forum / OpenSystem
            {
                textBoxGameID.Text += "1E";
            }
            else if (makerCode == "1F") // Virgin Games (Japan)
            {
                textBoxGameID.Text += "1F";
            }
            else if (makerCode == "1G") // SMDE
            {
                textBoxGameID.Text += "1G";
            }
            else if (makerCode == "1J") // Daikokudenki
            {
                textBoxGameID.Text += "1J";
            }
            else if (makerCode == "1K") // Titus Software
            {
                textBoxGameID.Text += "1K";
            }
            else if (makerCode == "1P") // Creatures Inc.
            {
                textBoxGameID.Text += "1P";
            }
            else if (makerCode == "1Q") // TDK Deep Impresion
            {
                textBoxGameID.Text += "1Q";
            }
            else if (makerCode == "2A") // Culture Brain
            {
                textBoxGameID.Text += "2A";
            }
            else if (makerCode == "2C") // Palsoft
            {
                textBoxGameID.Text += "2C";
            }
            else if (makerCode == "2D") // Visit Co.,Ltd.
            {
                textBoxGameID.Text += "2D";
            }
            else if (makerCode == "2E") // Intec
            {
                textBoxGameID.Text += "2E";
            }
            else if (makerCode == "2F") // System Sacom
            {
                textBoxGameID.Text += "2F";
            }
            else if (makerCode == "2G") // Poppo
            {
                textBoxGameID.Text += "2G";
            }
            else if (makerCode == "2H") // Ubisoft Japan
            {
                textBoxGameID.Text += "2H";
            }
            else if (makerCode == "2J") // Media Works
            {
                textBoxGameID.Text += "2J";
            }
            else if (makerCode == "2K") // NEC Interchannel
            {
                textBoxGameID.Text += "2K";
            }
            else if (makerCode == "2L") // Agatsuma Entertainment
            {
                textBoxGameID.Text += "2L";
            }
            else if (makerCode == "2M") // Jorudan
            {
                textBoxGameID.Text += "2M";
            }
            else if (makerCode == "2N") // Smilesoft / Rocket Company
            {
                textBoxGameID.Text += "2N";
            }
            else if (makerCode == "2Q") // MediaKite
            {
                textBoxGameID.Text += "2Q";
            }
            else if (makerCode == "3A") // Soedesco
            {
                textBoxGameID.Text += "3A";
            }
            else if (makerCode == "3B") // Arcade Zone Ltd
            {
                textBoxGameID.Text += "3B";
            }
            else if (makerCode == "3C") // Entertainment International / Empire Software
            {
                textBoxGameID.Text += "3C";
            }
            else if (makerCode == "3D") // Loriciel
            {
                textBoxGameID.Text += "3D";
            }
            else if (makerCode == "3E") // Gremlin Graphics
            {
                textBoxGameID.Text += "3E";
            }
            else if (makerCode == "3F") // K. Amusement Leasing Co.
            {
                textBoxGameID.Text += "3F";
            }
            else if (makerCode == "3T") // Petite Games
            {
                textBoxGameID.Text += "3T";
            }
            else if (makerCode == "4A") // Mirage Studios
            {
                textBoxGameID.Text += "4A";
            }
            else if (makerCode == "4B") // Raya Systems
            {
                textBoxGameID.Text += "4B";
            }
            else if (makerCode == "4C") // Renovation Products
            {
                textBoxGameID.Text += "4C";
            }
            else if (makerCode == "4D") // Malibu Games
            {
                textBoxGameID.Text += "4D";
            }
            else if (makerCode == "4F") // Eidos Interactive
            {
                textBoxGameID.Text += "4F";
            }
            else if (makerCode == "4G") // Palymates Interactive
            {
                textBoxGameID.Text += "4G";
            }
            else if (makerCode == "4J") // Fox Interactive
            {
                textBoxGameID.Text += "4J";
            }
            else if (makerCode == "4K") // Time Warner Interactive
            {
                textBoxGameID.Text += "4K";
            }
            else if (makerCode == "4Q") // Disney Interactive Studios / Buena Vista Games
            {
                textBoxGameID.Text += "4Q";
            }
            else if (makerCode == "4S") // Black Pearl
            {
                textBoxGameID.Text += "4S";
            }
            else if (makerCode == "4U") // Advanced Productions
            {
                textBoxGameID.Text += "4U";
            }
            else if (makerCode == "4X") // GT Interactive
            {
                textBoxGameID.Text += "4X";
            }
            else if (makerCode == "4Y") // RARE
            {
                textBoxGameID.Text += "4Y";
            }
            else if (makerCode == "4Z") // Crave Entertainment / Red Wagon Games
            {
                textBoxGameID.Text += "4Z";
            }
            else if (makerCode == "5A") // Mindscape Red Orb Entertainment
            {
                textBoxGameID.Text += "5A";
            }
            else if (makerCode == "5B") // Romstar
            {
                textBoxGameID.Text += "5B";
            }
            else if (makerCode == "5C") // Taxan
            {
                textBoxGameID.Text += "5C";
            }
            else if (makerCode == "5D") // Midway Games / Tradewest
            {
                textBoxGameID.Text += "5D";
            }
            else if (makerCode == "5F") // American Softworks
            {
                textBoxGameID.Text += "5F";
            }
            else if (makerCode == "5G") // Majesco Entertainment
            {
                textBoxGameID.Text += "5G";
            }
            else if (makerCode == "5H") // 3DO / Global Star Software
            {
                textBoxGameID.Text += "5H";
            }
            else if (makerCode == "5K") // Hasbro
            {
                textBoxGameID.Text += "5K";
            }
            else if (makerCode == "5L") // NewKidCo
            {
                textBoxGameID.Text += "5L";
            }
            else if (makerCode == "5M") // Telegames
            {
                textBoxGameID.Text += "5M";
            }
            else if (makerCode == "5N") // Metro3D
            {
                textBoxGameID.Text += "5N";
            }
            else if (makerCode == "5P") // Vatical Entertainment
            {
                textBoxGameID.Text += "5P";
            }
            else if (makerCode == "5Q") // LEGO Media
            {
                textBoxGameID.Text += "5Q";
            }
            else if (makerCode == "5S") // Evolved Games / Xicat Interactive
            {
                textBoxGameID.Text += "5S";
            }
            else if (makerCode == "5T") // Cryo Interactive
            {
                textBoxGameID.Text += "5T";
            }
            else if (makerCode == "5V") // Agetec
            {
                textBoxGameID.Text += "5V";
            }
            else if (makerCode == "5W") // Red Storm Entertainment
            {
                textBoxGameID.Text += "5W";
            }
            else if (makerCode == "5X") // Microids
            {
                textBoxGameID.Text += "5X";
            }
            else if (makerCode == "5Z") // Data Design /Conspiracy Entertainment
            {
                textBoxGameID.Text += "5Z";
            }
            else if (makerCode == "6B") // Laser Beam
            {
                textBoxGameID.Text += "6B";
            }
            else if (makerCode == "6E") // Elite Systems
            {
                textBoxGameID.Text += "6E";
            }
            else if (makerCode == "6F") // Electro Brain
            {
                textBoxGameID.Text += "6F";
            }
            else if (makerCode == "6G") // The Learning Company
            {
                textBoxGameID.Text += "6G";
            }
            else if (makerCode == "6H") // BBC
            {
                textBoxGameID.Text += "6H";
            }
            else if (makerCode == "6J") // Software 2000
            {
                textBoxGameID.Text += "6J";
            }
            else if (makerCode == "6K") // UFO Interactive Games
            {
                textBoxGameID.Text += "6K";
            }
            else if (makerCode == "6L") // BAM! Entertainment
            {
                textBoxGameID.Text += "6L";
            }
            else if (makerCode == "6M") // System 3
            {
                textBoxGameID.Text += "6M";
            }
            else if (makerCode == "6N") // Midas Interactive Entertainment
            {
                textBoxGameID.Text += "6N";
            }
            else if (makerCode == "6Q") // Classified Games
            {
                textBoxGameID.Text += "6Q";
            }
            else if (makerCode == "6S") // TDK Mediactive
            {
                textBoxGameID.Text += "6S";
            }
            else if (makerCode == "6U") // The Adventure Company / DreamCatcher Interactive
            {
                textBoxGameID.Text += "6U";
            }
            else if (makerCode == "6V") // JoWooD Entertainment
            {
                textBoxGameID.Text += "6V";
            }
            else if (makerCode == "6W") // SEGA
            {
                textBoxGameID.Text += "6W";
            }
            else if (makerCode == "6X") // Wanadoo Edition
            {
                textBoxGameID.Text += "6X";
            }
            else if (makerCode == "6Y") // LSP (Light & Shadow Prod.)
            {
                textBoxGameID.Text += "6Y";
            }
            else if (makerCode == "6Z") // NDS Software
            {
                textBoxGameID.Text += "6Z";
            }
            else if (makerCode == "7A") // Triffix Entertainment
            {
                textBoxGameID.Text += "7A";
            }
            else if (makerCode == "7C") // Microprose Software
            {
                textBoxGameID.Text += "7C";
            }
            else if (makerCode == "7D") // Sierra Entertainment / Vivendi Games / Universal Interactive Studios
            {
                textBoxGameID.Text += "7D";
            }
            else if (makerCode == "7F") // Kemco
            {
                textBoxGameID.Text += "7F";
            }
            else if (makerCode == "7G") // Rage Software
            {
                textBoxGameID.Text += "7G";
            }
            else if (makerCode == "7H") // Encore Software
            {
                textBoxGameID.Text += "7H";
            }
            else if (makerCode == "7J") // Zushi Games / ZOO Digital Publishing
            {
                textBoxGameID.Text += "7J";
            }
            else if (makerCode == "7K") // Kiddinx Entertainment
            {
                textBoxGameID.Text += "7K";
            }
            else if (makerCode == "7L") // Simon & Schuster Interactive
            {
                textBoxGameID.Text += "7L";
            }
            else if (makerCode == "7M") // Badland Games
            {
                textBoxGameID.Text += "7M";
            }
            else if (makerCode == "7N") // Empire Interactive / Xplosiv
            {
                textBoxGameID.Text += "7N";
            }
            else if (makerCode == "7Q") // Jester Interactive
            {
                textBoxGameID.Text += "7Q";
            }
            else if (makerCode == "7S") // Rockstar Games
            {
                textBoxGameID.Text += "7S";
            }
            else if (makerCode == "7T") // Scholastic
            {
                textBoxGameID.Text += "7T";
            }
            else if (makerCode == "7U") // Ignition Entertainment
            {
                textBoxGameID.Text += "7U";
            }
            else if (makerCode == "7V") // Summitsoft
            {
                textBoxGameID.Text += "7V";
            }
            else if (makerCode == "7W") // Stadbauer
            {
                textBoxGameID.Text += "7W";
            }
            else if (makerCode == "7X") // Nyamyam
            {
                textBoxGameID.Text += "7X";
            }
            else if (makerCode == "8B") // BulletProof Software (BPS)
            {
                textBoxGameID.Text += "8B";
            }
            else if (makerCode == "8C") // Vic Tokai Inc.
            {
                textBoxGameID.Text += "8C";
            }
            else if (makerCode == "8E") // Character Soft
            {
                textBoxGameID.Text += "8E";
            }
            else if (makerCode == "8F") // I'Max
            {
                textBoxGameID.Text += "8F";
            }
            else if (makerCode == "8G") // NEC Interchannel
            {
                textBoxGameID.Text += "8G";
            }
            else if (makerCode == "8J") // Kadokawa Shoten
            {
                textBoxGameID.Text += "8J";
            }
            else if (makerCode == "8M") // CyberFront
            {
                textBoxGameID.Text += "8M";
            }
            else if (makerCode == "8N") // Success
            {
                textBoxGameID.Text += "8N";
            }
            else if (makerCode == "8P") // SEGA
            {
                textBoxGameID.Text += "8P";
            }
            else if (makerCode == "8R") // Ludosity
            {
                textBoxGameID.Text += "8R";
            }
            else if (makerCode == "8U") // RCMADIAX
            {
                textBoxGameID.Text += "8U";
            }
            else if (makerCode == "8Z") // 2020venture
            {
                textBoxGameID.Text += "8Z";
            }
            else if (makerCode == "9A") // Nichibutsu / Nihon Bussan
            {
                textBoxGameID.Text += "9A";
            }
            else if (makerCode == "9B") // Tecmo
            {
                textBoxGameID.Text += "9B";
            }
            else if (makerCode == "9C") // Imagineer
            {
                textBoxGameID.Text += "9C";
            }
            else if (makerCode == "9F") // Nova
            {
                textBoxGameID.Text += "9F";
            }
            else if (makerCode == "9G") // Take-Two Interactive / Global Star Software / Gotham Games / Gathering of Developers
            {
                textBoxGameID.Text += "9G";
            }
            else if (makerCode == "9H") // Bottom Up
            {
                textBoxGameID.Text += "9H";
            }
            else if (makerCode == "9J") // TGL (Technical Group Laboratory)
            {
                textBoxGameID.Text += "9J";
            }
            else if (makerCode == "9L") // Hasbro Japan
            {
                textBoxGameID.Text += "9L";
            }
            else if (makerCode == "9N") // Marvelous Entertainment
            {
                textBoxGameID.Text += "9N";
            }
            else if (makerCode == "9P") // Keynet Inc.
            {
                textBoxGameID.Text += "9P";
            }
            else if (makerCode == "9Q") // Hands-On Entertainment
            {
                textBoxGameID.Text += "9Q";
            }
            else if (makerCode == "9S") // Brother International
            {
                textBoxGameID.Text += "9S";
            }
            else if (makerCode == "9T") // Fuzzy Wuzzy Games
            {
                textBoxGameID.Text += "9T";
            }
            else if (makerCode == "9V") // Wales Interactive
            {
                textBoxGameID.Text += "9V";
            }
            else if (makerCode == "9W") // BeautiFun Games
            {
                textBoxGameID.Text += "9W";
            }
            else if (makerCode == "9X") // PhobosLab
            {
                textBoxGameID.Text += "9X";
            }
            else if (makerCode == "9Z") // Crunchyroll
            {
                textBoxGameID.Text += "9Z";
            }
            else if (makerCode == "12") // Infocom
            {
                textBoxGameID.Text += "12";
            }
            else if (makerCode == "13") // Eletronic Arts Japan
            {
                textBoxGameID.Text += "13";
            }
            else if (makerCode == "15") // Cobra Team
            {
                textBoxGameID.Text += "15";
            }
            else if (makerCode == "16") // Human / Field
            {
                textBoxGameID.Text += "16";
            }
            else if (makerCode == "17") // KOEI
            {
                textBoxGameID.Text += "17";
            }
            else if (makerCode == "18") // Hudson Soft / Hudson Entertainment
            {
                textBoxGameID.Text += "18";
            }
            else if (makerCode == "19") // S.C.P.
            {
                textBoxGameID.Text += "19";
            }
            else if (makerCode == "20") // DSI Games / ZOO Digital Publishing
            {
                textBoxGameID.Text += "20";
            }
            else if (makerCode == "21") // Sunsoft / Tokai Engineering
            {
                textBoxGameID.Text += "21";
            }
            else if (makerCode == "22") // POW (Planning Office Wada) / VR1 Japan
            {
                textBoxGameID.Text += "22";
            }
            else if (makerCode == "23") // Micro World
            {
                textBoxGameID.Text += "23";
            }
            else if (makerCode == "25") // San-X
            {
                textBoxGameID.Text += "25";
            }
            else if (makerCode == "26") // Enix
            {
                textBoxGameID.Text += "26";
            }
            else if (makerCode == "27") // Loriciel / Electro Brain
            {
                textBoxGameID.Text += "27";
            }
            else if (makerCode == "28") // Kemco Japan
            {
                textBoxGameID.Text += "28";
            }
            else if (makerCode == "29") // SETA Corporation
            {
                textBoxGameID.Text += "29";
            }
            else if (makerCode == "30") // Viacom
            {
                textBoxGameID.Text += "30";
            }
            else if (makerCode == "31") // Carrozzeria
            {
                textBoxGameID.Text += "31";
            }
            else if (makerCode == "32") // Dynamic
            {
                textBoxGameID.Text += "32";
            }
            else if (makerCode == "33") // 
            {
                textBoxGameID.Text += "33";
            }
            else if (makerCode == "34") // Magifact
            {
                textBoxGameID.Text += "34";
            }
            else if (makerCode == "35") // Hect
            {
                textBoxGameID.Text += "35";
            }
            else if (makerCode == "36") // Codemasters
            {
                textBoxGameID.Text += "36";
            }
            else if (makerCode == "37") // Taito / GAGA Communications
            {
                textBoxGameID.Text += "37";
            }
            else if (makerCode == "38") // Laguna
            {
                textBoxGameID.Text += "38";
            }
            else if (makerCode == "39") // Telstar / Event / Taito
            {
                textBoxGameID.Text += "39";
            }
            else if (makerCode == "40") // Seika Corp.
            {
                textBoxGameID.Text += "40";
            }
            else if (makerCode == "41") // Ubisoft
            {
                textBoxGameID.Text += "41";
            }
            else if (makerCode == "42") // Sunsoft US
            {
                textBoxGameID.Text += "42";
            }
            else if (makerCode == "44") // Life Fitness
            {
                textBoxGameID.Text += "44";
            }
            else if (makerCode == "46") // System 3
            {
                textBoxGameID.Text += "46";
            }
            else if (makerCode == "47") // Spectrum Holobyte
            {
                textBoxGameID.Text += "47";
            }
            else if (makerCode == "49") // IREM
            {
                textBoxGameID.Text += "49";
            }
            else if (makerCode == "50") // Absolute Entertainment
            {
                textBoxGameID.Text += "50";
            }
            else if (makerCode == "51") // Acclaim Entertainment
            {
                textBoxGameID.Text += "51";
            }
            else if (makerCode == "52") // Activision
            {
                textBoxGameID.Text += "52";
            }
            else if (makerCode == "53") // American Sammy
            {
                textBoxGameID.Text += "53";
            }
            else if (makerCode == "54") // Take-two Interactive / GameTek / Rockstar Games / Global Star Software
            {
                textBoxGameID.Text += "54";
            }
            else if (makerCode == "55") // Hi Tech
            {
                textBoxGameID.Text += "55";
            }
            else if (makerCode == "56") // LJN LTD.
            {
                textBoxGameID.Text += "56";
            }
            else if (makerCode == "58") // Mattel
            {
                textBoxGameID.Text += "58";
            }
            else if (makerCode == "60") // Titus Interactive / Titus Software
            {
                textBoxGameID.Text += "60";
            }
            else if (makerCode == "61") // Virgin Interactive
            {
                textBoxGameID.Text += "61";
            }
            else if (makerCode == "62") // Maxis
            {
                textBoxGameID.Text += "62";
            }
            else if (makerCode == "64") // LucasArts
            {
                textBoxGameID.Text += "64";
            }
            else if (makerCode == "67") // Ocean
            {
                textBoxGameID.Text += "67";
            }
            else if (makerCode == "68") // Bethesda Softworks / Mud Duck Productions / Vir2L Studios
            {
                textBoxGameID.Text += "68";
            }
            else if (makerCode == "69") // Eletronic Arts
            {
                textBoxGameID.Text += "69";
            }
            else if (makerCode == "70") // Atari (Infogrames)
            {
                textBoxGameID.Text += "70";
            }
            else if (makerCode == "71") // Interplay Entertainment
            {
                textBoxGameID.Text += "71";
            }
            else if (makerCode == "72") // JVC (US)
            {
                textBoxGameID.Text += "72";
            }
            else if (makerCode == "73") // Parker Brothers
            {
                textBoxGameID.Text += "73";
            }
            else if (makerCode == "75") // SCI Games
            {
                textBoxGameID.Text += "75";
            }
            else if (makerCode == "78") // THQ / Play THQ
            {
                textBoxGameID.Text += "78";
            }
            else if (makerCode == "79") // Accolade
            {
                textBoxGameID.Text += "79";
            }
            else if (makerCode == "80") // Misawa
            {
                textBoxGameID.Text += "80";
            }
            else if (makerCode == "81") // Teichiku
            {
                textBoxGameID.Text += "81";
            }
            else if (makerCode == "82") // Namco
            {
                textBoxGameID.Text += "82";
            }
            else if (makerCode == "83") // LOZC
            {
                textBoxGameID.Text += "83";
            }
            else if (makerCode == "84") // KOEI
            {
                textBoxGameID.Text += "84";
            }
            else if (makerCode == "86") // Tokuma Shoten Intermedia
            {
                textBoxGameID.Text += "86";
            }
            else if (makerCode == "87") // Tsukuda Original
            {
                textBoxGameID.Text += "87";
            }
            else if (makerCode == "88") // DATAM-Polystar
            {
                textBoxGameID.Text += "88";
            }
            else if (makerCode == "90") // Takara Amusement
            {
                textBoxGameID.Text += "90";
            }
            else if (makerCode == "91") // Chunsoft
            {
                textBoxGameID.Text += "91";
            }
            else if (makerCode == "92") // Video System / Mc O' River
            {
                textBoxGameID.Text += "92";
            }
            else if (makerCode == "93") // BEC
            {
                textBoxGameID.Text += "93";
            }
            else if (makerCode == "95") // Varie
            {
                textBoxGameID.Text += "95";
            }
            else if (makerCode == "96") // Yonezawa / S'pal
            {
                textBoxGameID.Text += "96";
            }
            else if (makerCode == "97") // Kaneko
            {
                textBoxGameID.Text += "97";
            }
            else if (makerCode == "99") // Marvelous Entertainment / Victor Entertainment / Pack-In-Video / Rising Star Games
            {
                textBoxGameID.Text += "99";
            }
            else if (makerCode == "A0") // Telenet
            {
                textBoxGameID.Text += "A0";
            }
            else if (makerCode == "A1") // Hori
            {
                textBoxGameID.Text += "A1";
            }
            else if (makerCode == "A4") // Konami
            {
                textBoxGameID.Text += "A4";
            }
            else if (makerCode == "A5") // K. Amusement Leasing Co.
            {
                textBoxGameID.Text += "A5";
            }
            else if (makerCode == "A6") // Kawada
            {
                textBoxGameID.Text += "A6";
            }
            else if (makerCode == "A7") // Takara
            {
                textBoxGameID.Text += "A7";
            }
            else if (makerCode == "A9") // Technos Japan Corp.
            {
                textBoxGameID.Text += "A9";
            }
            else if (makerCode == "AA") // JVC / Victor
            {
                textBoxGameID.Text += "AA";
            }
            else if (makerCode == "AC") // Toei Animation
            {
                textBoxGameID.Text += "AC";
            }
            else if (makerCode == "AD") // Toho
            {
                textBoxGameID.Text += "AD";
            }
            else if (makerCode == "AF") // Namco Bandai Games
            {
                textBoxGameID.Text += "AF";
            }
            else if (makerCode == "AG") // Media Rings Corporation
            {
                textBoxGameID.Text += "AG";
            }
            else if (makerCode == "AH") // J-Wing
            {
                textBoxGameID.Text += "AH";
            }
            else if (makerCode == "AJ") // Pioneer LDC
            {
                textBoxGameID.Text += "AJ";
            }
            else if (makerCode == "AK") // KID
            {
                textBoxGameID.Text += "AK";
            }
            else if (makerCode == "AL") // Mediafactory
            {
                textBoxGameID.Text += "AL";
            }
            else if (makerCode == "AP") // Infogrames / Hudson
            {
                textBoxGameID.Text += "AP";
            }
            else if (makerCode == "AQ") // Kiratto. Ludic Inc
            {
                textBoxGameID.Text += "AQ";
            }
            else if (makerCode == "AU") // Alternative Software
            {
                textBoxGameID.Text += "AU";
            }
            else if (makerCode == "AW") // Henchmen Studio
            {
                textBoxGameID.Text += "AW";
            }
            else if (makerCode == "AX") // Vivendi
            {
                textBoxGameID.Text += "AX";
            }
            else if (makerCode == "AY") // Yacht Club Games
            {
                textBoxGameID.Text += "AY";
            }
            else if (makerCode == "B0") // Acclaim Japan
            {
                textBoxGameID.Text += "B0";
            }
            else if (makerCode == "B1") // ASCII
            {
                textBoxGameID.Text += "B1";
            }
            else if (makerCode == "B2") // Bandai Games
            {
                textBoxGameID.Text += "B2";
            }
            else if (makerCode == "B4") // Enix
            {
                textBoxGameID.Text += "B4";
            }
            else if (makerCode == "B6") // HAL Laboratory
            {
                textBoxGameID.Text += "B6";
            }
            else if (makerCode == "B7") // SNK
            {
                textBoxGameID.Text += "B7";
            }
            else if (makerCode == "B9") // Pony Canyon
            {
                textBoxGameID.Text += "B9";
            }
            else if (makerCode == "BA") // Culture Brain
            {
                textBoxGameID.Text += "BA";
            }
            else if (makerCode == "BB") // Sunsoft
            {
                textBoxGameID.Text += "BB";
            }
            else if (makerCode == "BC") // Toshiba EMI
            {
                textBoxGameID.Text += "BC";
            }
            else if (makerCode == "BD") // Sony Imagesoft
            {
                textBoxGameID.Text += "BD";
            }
            else if (makerCode == "BF") // Sammy
            {
                textBoxGameID.Text += "BF";
            }
            else if (makerCode == "BG") // Magical
            {
                textBoxGameID.Text += "BG";
            }
            else if (makerCode == "BH") // Visco
            {
                textBoxGameID.Text += "BH";
            }
            else if (makerCode == "BJ") // Complie
            {
                textBoxGameID.Text += "BJ";
            }
            else if (makerCode == "BL") // MTO
            {
                textBoxGameID.Text += "BL";
            }
            else if (makerCode == "BM") // XING
            {
                textBoxGameID.Text += "BM";
            }
            else if (makerCode == "BN") // Sunrise Interactive
            {
                textBoxGameID.Text += "BN";
            }
            else if (makerCode == "BP") // Global A Entertainment
            {
                textBoxGameID.Text += "BP";
            }
            else if (makerCode == "BQ") // Fuuki
            {
                textBoxGameID.Text += "BQ";
            }
            else if (makerCode == "BV") // The Game Bakers
            {
                textBoxGameID.Text += "BV";
            }
            else if (makerCode == "C0") // Taito
            {
                textBoxGameID.Text += "C0";
            }
            else if (makerCode == "C2") // Kemco
            {
                textBoxGameID.Text += "C2";
            }
            else if (makerCode == "C3") // Square
            {
                textBoxGameID.Text += "C3";
            }
            else if (makerCode == "C4") // Tokuma Shoten
            {
                textBoxGameID.Text += "C4";
            }
            else if (makerCode == "C5") // Data East
            {
                textBoxGameID.Text += "C5";
            }
            else if (makerCode == "C6") // Tonkin House / Tokyo Shoseki
            {
                textBoxGameID.Text += "C6";
            }
            else if (makerCode == "C8") // Koei
            {
                textBoxGameID.Text += "C8";
            }
            else if (makerCode == "CA") // Konami / Ultra / Palcom
            {
                textBoxGameID.Text += "CA";
            }
            else if (makerCode == "CB") // NTVIC / VAP
            {
                textBoxGameID.Text += "CB";
            }
            else if (makerCode == "CC") // Use Co., Ltd.
            {
                textBoxGameID.Text += "CC";
            }
            else if (makerCode == "CD") // Meldac
            {
                textBoxGameID.Text += "CD";
            }
            else if (makerCode == "CE") // Pony Canyon / FCI
            {
                textBoxGameID.Text += "CE";
            }
            else if (makerCode == "CF") // Angel / Sotsu / Agency / Sunrise
            {
                textBoxGameID.Text += "CF";
            }
            else if (makerCode == "CG") // Yumedia / Aroma Co., Ltd
            {
                textBoxGameID.Text += "CG";
            }
            else if (makerCode == "CJ") // Boss
            {
                textBoxGameID.Text += "CJ";
            }
            else if (makerCode == "CK") // Alexa / Crea-Tech
            {
                textBoxGameID.Text += "CK";
            }
            else if (makerCode == "CL") // Sekaibunka-Sha / Sumire Kobo / Marigul Management Inc.
            {
                textBoxGameID.Text += "CL";
            }
            else if (makerCode == "CM") // Konami Computer Entertainment Osaka
            {
                textBoxGameID.Text += "CM";
            }
            else if (makerCode == "CN") // NEC Interchannel
            {
                textBoxGameID.Text += "CN";
            }
            else if (makerCode == "CP") // Enterbrain
            {
                textBoxGameID.Text += "CP";
            }
            else if (makerCode == "CQ") // From Software
            {
                textBoxGameID.Text += "CQ";
            }
            else if (makerCode == "CX") // Black Forest Games
            {
                textBoxGameID.Text += "CX";
            }
            else if (makerCode == "CY") // Ripstone
            {
                textBoxGameID.Text += "CY";
            }
            else if (makerCode == "D0") // Taito / Disco
            {
                textBoxGameID.Text += "D0";
            }
            else if (makerCode == "D1") // Sofei
            {
                textBoxGameID.Text += "D1";
            }
            else if (makerCode == "D2") // Quest / Bothtec
            {
                textBoxGameID.Text += "D2";
            }
            else if (makerCode == "D3") // Sigma
            {
                textBoxGameID.Text += "D3";
            }
            else if (makerCode == "D4") // Ask Kodansha
            {
                textBoxGameID.Text += "D4";
            }
            else if (makerCode == "D6") // Naxat
            {
                textBoxGameID.Text += "D6";
            }
            else if (makerCode == "D7") // Copya System
            {
                textBoxGameID.Text += "D7";
            }
            else if (makerCode == "D8") // Capcom Co., Ltd.
            {
                textBoxGameID.Text += "D8";
            }
            else if (makerCode == "D9") // Banpresto
            {
                textBoxGameID.Text += "D9";
            }
            else if (makerCode == "DA") // Tomy / Takara Tomy
            {
                textBoxGameID.Text += "DA";
            }
            else if (makerCode == "DB") // LJN Japan
            {
                textBoxGameID.Text += "DB";
            }
            else if (makerCode == "DD") // NCS
            {
                textBoxGameID.Text += "DD";
            }
            else if (makerCode == "DE") // Human Entertainment
            {
                textBoxGameID.Text += "DE";
            }
            else if (makerCode == "DF") // Altron
            {
                textBoxGameID.Text += "DF";
            }
            else if (makerCode == "DG") // Jaleco
            {
                textBoxGameID.Text += "DG";
            }
            else if (makerCode == "DH") // Gaps Inc.
            {
                textBoxGameID.Text += "DH";
            }
            else if (makerCode == "DN") // Elf
            {
                textBoxGameID.Text += "DN";
            }
            else if (makerCode == "DQ") // Compile Heart / Idea FActory
            {
                textBoxGameID.Text += "DQ";
            }
            else if (makerCode == "DU") // Mojang
            {
                textBoxGameID.Text += "DU";
            }
            else if (makerCode == "DV") // FarSight Studios
            {
                textBoxGameID.Text += "DV";
            }
            else if (makerCode == "DZ") // Moving Player
            {
                textBoxGameID.Text += "DZ";
            }
            else if (makerCode == "E0") // Jaleco
            {
                textBoxGameID.Text += "E0";
            }
            else if (makerCode == "E2") // Yutaka
            {
                textBoxGameID.Text += "E2";
            }
            else if (makerCode == "E3") // Varie
            {
                textBoxGameID.Text += "E3";
            }
            else if (makerCode == "E4") // T&ESoft
            {
                textBoxGameID.Text += "E4";
            }
            else if (makerCode == "E5") // Epoch
            {
                textBoxGameID.Text += "E5";
            }
            else if (makerCode == "E6") // Game Arts
            {
                textBoxGameID.Text += "E6";
            }
            else if (makerCode == "E7") // Athena
            {
                textBoxGameID.Text += "E7";
            }
            else if (makerCode == "E8") // Asmik Ace Entertainment
            {
                textBoxGameID.Text += "E8";
            }
            else if (makerCode == "E9") // Natsume
            {
                textBoxGameID.Text += "E9";
            }
            else if (makerCode == "EA") // King Records
            {
                textBoxGameID.Text += "EA";
            }
            else if (makerCode == "EB") // Atlus
            {
                textBoxGameID.Text += "EB";
            }
            else if (makerCode == "EC") // Epic / Sony Records
            {
                textBoxGameID.Text += "EC";
            }
            else if (makerCode == "EE") // IGS (Information Global Services)
            {
                textBoxGameID.Text += "EE";
            }
            else if (makerCode == "EG") // Chatnoir
            {
                textBoxGameID.Text += "EG";
            }
            else if (makerCode == "EH") // Right Stuff
            {
                textBoxGameID.Text += "EH";
            }
            else if (makerCode == "EL") // Spike
            {
                textBoxGameID.Text += "EL";
            }
            else if (makerCode == "EM") // Konami Computer Entertainment Tokyo
            {
                textBoxGameID.Text += "EM";
            }
            else if (makerCode == "EN") // Alphadream Corporation
            {
                textBoxGameID.Text += "EN";
            }
            else if (makerCode == "EP") // Sting Entertainment
            {
                textBoxGameID.Text += "EP";
            }
            else if (makerCode == "ES") // Starfish-SD
            {
                textBoxGameID.Text += "ES";
            }
            else if (makerCode == "ET") // Joindots GmbH
            {
                textBoxGameID.Text += "ET";
            }
            else if (makerCode == "EY") // Vblank Entertainment
            {
                textBoxGameID.Text += "EY";
            }
            else if (makerCode == "F0") // A Wave
            {
                textBoxGameID.Text += "F0";
            }
            else if (makerCode == "F1") // Motown Software
            {
                textBoxGameID.Text += "F1";
            }
            else if (makerCode == "F2") // Left Field Enternatinment
            {
                textBoxGameID.Text += "F2";
            }
            else if (makerCode == "F3") // Extreme Ent. Grp.
            {
                textBoxGameID.Text += "F3";
            }
            else if (makerCode == "F4") // TecMagik
            {
                textBoxGameID.Text += "F4";
            }
            else if (makerCode == "F9") // Cybersoft
            {
                textBoxGameID.Text += "F9";
            }
            else if (makerCode == "FB") // Psygnosis
            {
                textBoxGameID.Text += "FB";
            }
            else if (makerCode == "FE") // Davidson / Western Tech.
            {
                textBoxGameID.Text += "FE";
            }
            else if (makerCode == "FH") // Easy Interactive
            {
                textBoxGameID.Text += "FH";
            }
            else if (makerCode == "FJ") // Virtual Toys
            {
                textBoxGameID.Text += "FJ";
            }
            else if (makerCode == "FK") // The Game Factory
            {
                textBoxGameID.Text += "FK";
            }
            else if (makerCode == "FL") // Hip Games
            {
                textBoxGameID.Text += "FL";
            }
            else if (makerCode == "FM") // Aspyr
            {
                textBoxGameID.Text += "FM";
            }
            else if (makerCode == "FP") // Mastiff
            {
                textBoxGameID.Text += "FP";
            }
            else if (makerCode == "FQ") // iQue
            {
                textBoxGameID.Text += "FQ";
            }
            else if (makerCode == "FR") // Digital Tainment Pool
            {
                textBoxGameID.Text += "FR";
            }
            else if (makerCode == "FS") // XS Games
            {
                textBoxGameID.Text += "FS";
            }
            else if (makerCode == "FT") // Daiwon
            {
                textBoxGameID.Text += "FT";
            }
            else if (makerCode == "FV") // Horberg Productions, Flyhigh Works
            {
                textBoxGameID.Text += "FV";
            }
            else if (makerCode == "FZ") // Frozenbyte
            {
                textBoxGameID.Text += "FZ";
            }
            else if (makerCode == "G0") // Alpha Unit
            {
                textBoxGameID.Text += "G0";
            }
            else if (makerCode == "G1") // PCCW Japan
            {
                textBoxGameID.Text += "G1";
            }
            else if (makerCode == "G2") // Yuke's
            {
                textBoxGameID.Text += "G2";
            }
            else if (makerCode == "G4") // KiKi Co Ltd
            {
                textBoxGameID.Text += "G4";
            }
            else if (makerCode == "G5") // Open Sesame Inc
            {
                textBoxGameID.Text += "G5";
            }
            else if (makerCode == "G6") // SIMS
            {
                textBoxGameID.Text += "G6";
            }
            else if (makerCode == "G7") // Broccoli
            {
                textBoxGameID.Text += "G7";
            }
            else if (makerCode == "G8") // Avex
            {
                textBoxGameID.Text += "G8";
            }
            else if (makerCode == "G9") // D3 Publisher
            {
                textBoxGameID.Text += "G9";
            }
            else if (makerCode == "GA") // PIN Change
            {
                textBoxGameID.Text += "GA";
            }
            else if (makerCode == "GB") // Konami Computer Entertainment Japan
            {
                textBoxGameID.Text += "GB";
            }
            else if (makerCode == "GD") // Square Enix
            {
                textBoxGameID.Text += "GD";
            }
            else if (makerCode == "GE") // Kids Station
            {
                textBoxGameID.Text += "GE";
            }
            else if (makerCode == "GF") // Mocott & Basara Inc.
            {
                textBoxGameID.Text += "GF";
            }
            else if (makerCode == "GG") // O3 Entertainment
            {
                textBoxGameID.Text += "GG";
            }
            else if (makerCode == "GH") // Orbital Media
            {
                textBoxGameID.Text += "GH";
            }
            else if (makerCode == "GJ") // Detn8 Games
            {
                textBoxGameID.Text += "GJ";
            }
            else if (makerCode == "GK") // Genki
            {
                textBoxGameID.Text += "GK";
            }
            else if (makerCode == "GL") // Gameloft / Ubisoft
            {
                textBoxGameID.Text += "GL";
            }
            else if (makerCode == "GM") // GameCock Media Group
            {
                textBoxGameID.Text += "GM";
            }
            else if (makerCode == "GN") // Oxygen Games
            {
                textBoxGameID.Text += "GN";
            }
            else if (makerCode == "GR") // GSP
            {
                textBoxGameID.Text += "GR";
            }
            else if (makerCode == "GT") // 505 Games
            {
                textBoxGameID.Text += "GT";
            }
            else if (makerCode == "GX") // Commodore
            {
                textBoxGameID.Text += "GX";
            }
            else if (makerCode == "GY") // The Game Factory
            {
                textBoxGameID.Text += "GY";
            }
            else if (makerCode == "GZ") // Gammick Entertainment
            {
                textBoxGameID.Text += "GZ";
            }
            else if (makerCode == "H1") // Treasure
            {
                textBoxGameID.Text += "H1";
            }
            else if (makerCode == "H2") // Aruze
            {
                textBoxGameID.Text += "H2";
            }
            else if (makerCode == "H3") // Zen United
            {
                textBoxGameID.Text += "H3";
            }
            else if (makerCode == "H4") // SNK Playmore
            {
                textBoxGameID.Text += "H4";
            }
            else if (makerCode == "HA") // Nobilis
            {
                textBoxGameID.Text += "HA";
            }
            else if (makerCode == "HE") // Gust
            {
                textBoxGameID.Text += "HE";
            }
            else if (makerCode == "HF") // Level-5
            {
                textBoxGameID.Text += "HF";
            }
            else if (makerCode == "HG") // Graffiti Entertainment
            {
                textBoxGameID.Text += "HG";
            }
            else if (makerCode == "HH") // Focus Home Interactive
            {
                textBoxGameID.Text += "HH";
            }
            else if (makerCode == "HJ") // Genius Products
            {
                textBoxGameID.Text += "HJ";
            }
            else if (makerCode == "HK") // D2C Games
            {
                textBoxGameID.Text += "HK";
            }
            else if (makerCode == "HL") // Frontier Developments
            {
                textBoxGameID.Text += "HL";
            }
            else if (makerCode == "HM") // HMH Interactive
            {
                textBoxGameID.Text += "HM";
            }
            else if (makerCode == "HN") // High Voltage Software
            {
                textBoxGameID.Text += "HN";
            }
            else if (makerCode == "HQ") // Abstraction Games
            {
                textBoxGameID.Text += "HQ";
            }
            else if (makerCode == "HS") // Tru Blu
            {
                textBoxGameID.Text += "HS";
            }
            else if (makerCode == "HT") // Big Blue Bubble
            {
                textBoxGameID.Text += "HT";
            }
            else if (makerCode == "HU") // Ghostfire Games
            {
                textBoxGameID.Text += "HU";
            }
            else if (makerCode == "HW") // Incredible Technologies
            {
                textBoxGameID.Text += "HW";
            }
            else if (makerCode == "HY") // Reef Entertainment
            {
                textBoxGameID.Text += "HY";
            }
            else if (makerCode == "HZ") // Nordcurrent
            {
                textBoxGameID.Text += "HZ";
            }
            else if (makerCode == "IH") // Yojigen
            {
                textBoxGameID.Text += "IH";
            }
            else if (makerCode == "J8") // D4 Enterprise
            {
                textBoxGameID.Text += "J8";
            }
            else if (makerCode == "J9") // AQ Interactive
            {
                textBoxGameID.Text += "J9";
            }
            else if (makerCode == "JD") // SKONEC Entertainment
            {
                textBoxGameID.Text += "JD";
            }
            else if (makerCode == "JE") // E Frontier
            {
                textBoxGameID.Text += "JE";
            }
            else if (makerCode == "JF") // Arc System Works
            {
                textBoxGameID.Text += "JF";
            }
            else if (makerCode == "JG") // The Games Company
            {
                textBoxGameID.Text += "JG";
            }
            else if (makerCode == "JH") // City Interactive
            {
                textBoxGameID.Text += "JH";
            }
            else if (makerCode == "JJ") // Deep Silver
            {
                textBoxGameID.Text += "JJ";
            }
            else if (makerCode == "JP") // Redspotgames
            {
                textBoxGameID.Text += "JP";
            }
            else if (makerCode == "JR") // Engine Software
            {
                textBoxGameID.Text += "JR";
            }
            else if (makerCode == "JS") // Digital Leisure
            {
                textBoxGameID.Text += "JS";
            }
            else if (makerCode == "JT") // Empty Clip Studios
            {
                textBoxGameID.Text += "JT";
            }
            else if (makerCode == "JU") // Riverman Media
            {
                textBoxGameID.Text += "JU";
            }
            else if (makerCode == "JV") // JV Games
            {
                textBoxGameID.Text += "JV";
            }
            else if (makerCode == "JW") // BigBen Interactive
            {
                textBoxGameID.Text += "JW";
            }
            else if (makerCode == "JX") // Shin'en Multimedia
            {
                textBoxGameID.Text += "JX";
            }
            else if (makerCode == "JY") // Steel Penny Games
            {
                textBoxGameID.Text += "JY";
            }
            else if (makerCode == "JZ") // 505 Games
            {
                textBoxGameID.Text += "JZ";
            }
            else if (makerCode == "K2") // Coca-Cola (Japan) Company
            {
                textBoxGameID.Text += "K2";
            }
            else if (makerCode == "K3") // Yudo
            {
                textBoxGameID.Text += "K3";
            }
            else if (makerCode == "K6") // Nihon System
            {
                textBoxGameID.Text += "K6";
            }
            else if (makerCode == "KB") // Nippon Ichi Software
            {
                textBoxGameID.Text += "KB";
            }
            else if (makerCode == "KG") // Kando Games
            {
                textBoxGameID.Text += "KG";
            }
            else if (makerCode == "KH") // Joju Games
            {
                textBoxGameID.Text += "KH";
            }
            else if (makerCode == "KJ") // Studio Zan
            {
                textBoxGameID.Text += "KJ";
            }
            else if (makerCode == "KK") // DK Games
            {
                textBoxGameID.Text += "KK";
            }
            else if (makerCode == "KL") // Abylight
            {
                textBoxGameID.Text += "KL";
            }
            else if (makerCode == "KM") // Deep Silver
            {
                textBoxGameID.Text += "KM";
            }
            else if (makerCode == "KN") // Gameshastra
            {
                textBoxGameID.Text += "KN";
            }
            else if (makerCode == "KP") // Purple Hills
            {
                textBoxGameID.Text += "KP";
            }
            else if (makerCode == "KQ") // Over the top Games
            {
                textBoxGameID.Text += "KQ";
            }
            else if (makerCode == "KR") // KREA Medie
            {
                textBoxGameID.Text += "KR";
            }
            else if (makerCode == "KT") // The Code Monkeys
            {
                textBoxGameID.Text += "KT";
            }
            else if (makerCode == "KW") // Semnat Studios
            {
                textBoxGameID.Text += "KW";
            }
            else if (makerCode == "KY") // Medaverse Studios
            {
                textBoxGameID.Text += "KY";
            }
            else if (makerCode == "L3") // G-Mode
            {
                textBoxGameID.Text += "L3";
            }
            else if (makerCode == "L8") // FujiSoft
            {
                textBoxGameID.Text += "L8";
            }
            else if (makerCode == "LB") // Tryfirst
            {
                textBoxGameID.Text += "LB";
            }
            else if (makerCode == "LD") // Studio Zan
            {
                textBoxGameID.Text += "LD";
            }
            else if (makerCode == "LF") // Kemco
            {
                textBoxGameID.Text += "LF";
            }
            else if (makerCode == "LG") // Black Bean Games
            {
                textBoxGameID.Text += "LG";
            }
            else if (makerCode == "LH") // Trend Verlag / East Entertainment
            {
                textBoxGameID.Text += "LH";
            }
            else if (makerCode == "LJ") // Legendo Entertainment
            {
                textBoxGameID.Text += "LJ";
            }
            else if (makerCode == "LL") // HB Studios
            {
                textBoxGameID.Text += "LL";
            }
            else if (makerCode == "LN") // GameOn
            {
                textBoxGameID.Text += "LN";
            }
            else if (makerCode == "LP") // Left Field Productions
            {
                textBoxGameID.Text += "LP";
            }
            else if (makerCode == "LR") // Koch Media
            {
                textBoxGameID.Text += "LR";
            }
            else if (makerCode == "LT") // Legacy Interactive
            {
                textBoxGameID.Text += "LT";
            }
            else if (makerCode == "LU") // Lexis Numérique
            {
                textBoxGameID.Text += "LU";
            }
            else if (makerCode == "LW") // Grendel Games
            {
                textBoxGameID.Text += "LW";
            }
            else if (makerCode == "LY") // Icon Games / Super Icon
            {
                textBoxGameID.Text += "LY";
            }
            else if (makerCode == "M0") // Studio Zan
            {
                textBoxGameID.Text += "M0";
            }
            else if (makerCode == "M1") // Grand Prix Games
            {
                textBoxGameID.Text += "M1";
            }
            else if (makerCode == "M2") // HomeMedia
            {
                textBoxGameID.Text += "M2";
            }
            else if (makerCode == "M4") // Cybird
            {
                textBoxGameID.Text += "M4";
            }
            else if (makerCode == "M6") // Perpetuum
            {
                textBoxGameID.Text += "M6";
            }
            else if (makerCode == "MB") // Agenda
            {
                textBoxGameID.Text += "MB";
            }
            else if (makerCode == "MD") // Ateam
            {
                textBoxGameID.Text += "MD";
            }
            else if (makerCode == "ME") // Silver Star Japan
            {
                textBoxGameID.Text += "ME";
            }
            else if (makerCode == "MF") // Yamasa
            {
                textBoxGameID.Text += "MF";
            }
            else if (makerCode == "MH") // Mentor Interactive
            {
                textBoxGameID.Text += "MH";
            }
            else if (makerCode == "MJ") // Mumbo Jumbo
            {
                textBoxGameID.Text += "MJ";
            }
            else if (makerCode == "ML") // DTP Young Entertainment
            {
                textBoxGameID.Text += "ML";
            }
            else if (makerCode == "MM") // Big John Games
            {
                textBoxGameID.Text += "MM";
            }
            else if (makerCode == "MN") // Mindscape
            {
                textBoxGameID.Text += "MN";
            }
            else if (makerCode == "MR") // Mindscape
            {
                textBoxGameID.Text += "MR";
            }
            else if (makerCode == "MS") // Milestone / UFO Interactive Games
            {
                textBoxGameID.Text += "MS";
            }
            else if (makerCode == "MT") // Blast! Entertainment
            {
                textBoxGameID.Text += "MT";
            }
            else if (makerCode == "MV") // Marvelous Entertainment
            {
                textBoxGameID.Text += "MV";
            }
            else if (makerCode == "MZ") // Mad Catz
            {
                textBoxGameID.Text += "MZ";
            }
            else if (makerCode == "N0") // Exkee
            {
                textBoxGameID.Text += "N0";
            }
            else if (makerCode == "N4") // Zoom
            {
                textBoxGameID.Text += "N4";
            }
            else if (makerCode == "N7") // T&S
            {
                textBoxGameID.Text += "N7";
            }
            else if (makerCode == "N9") // Tera Box
            {
                textBoxGameID.Text += "N9";
            }
            else if (makerCode == "NA") // Tom Create
            {
                textBoxGameID.Text += "NA";
            }
            else if (makerCode == "NB") // HI Games & Publishing
            {
                textBoxGameID.Text += "NB";
            }
            else if (makerCode == "NE") // Kosaido
            {
                textBoxGameID.Text += "NE";
            }
            else if (makerCode == "NF") // Peakvox
            {
                textBoxGameID.Text += "NF";
            }
            else if (makerCode == "NG") // Nordic Games
            {
                textBoxGameID.Text += "NG";
            }
            else if (makerCode == "NH") // Gevo Entertainment
            {
                textBoxGameID.Text += "NH";
            }
            else if (makerCode == "NJ") // Enjoy Gaming
            {
                textBoxGameID.Text += "NJ";
            }
            else if (makerCode == "NK") // Neko Entertainment
            {
                textBoxGameID.Text += "NK";
            }
            else if (makerCode == "NL") // Nordic Softsales
            {
                textBoxGameID.Text += "NL";
            }
            else if (makerCode == "NN") // Nnooo
            {
                textBoxGameID.Text += "NN";
            }
            else if (makerCode == "NP") // Nobilis
            {
                textBoxGameID.Text += "NP";
            }
            else if (makerCode == "NQ") // Namco Bandai Partners
            {
                textBoxGameID.Text += "NQ";
            }
            else if (makerCode == "NR") // Destineer Publishing / Bold Games
            {
                textBoxGameID.Text += "NR";
            }
            else if (makerCode == "NS") // Nippon Ichi Software America
            {
                textBoxGameID.Text += "NS";
            }
            else if (makerCode == "NT") // Nocturnal Entertainment
            {
                textBoxGameID.Text += "NT";
            }
            else if (makerCode == "NV") // Nicalis
            {
                textBoxGameID.Text += "NV";
            }
            else if (makerCode == "NW") // Deep Field Entertainment
            {
                textBoxGameID.Text += "NW";
            }
            else if (makerCode == "NX") // Barnstorm Games
            {
                textBoxGameID.Text += "NX";
            }
            else if (makerCode == "NY") // Nicalis
            {
                textBoxGameID.Text += "NY";
            }
            else if (makerCode == "P1") // Poisoft
            {
                textBoxGameID.Text += "P1";
            }
            else if (makerCode == "PG") // Phoenix Games
            {
                textBoxGameID.Text += "PG";
            }
            else if (makerCode == "PH") // Playful Entertainment
            {
                textBoxGameID.Text += "PH";
            }
            else if (makerCode == "PK") // Knowledge Adventure
            {
                textBoxGameID.Text += "PK";
            }
            else if (makerCode == "PL") // Playlogic Entertainment
            {
                textBoxGameID.Text += "PL";
            }
            else if (makerCode == "PM") // Warner Bros. Interactive Entertainment
            {
                textBoxGameID.Text += "PM";
            }
            else if (makerCode == "PN") // P2 Games
            {
                textBoxGameID.Text += "PN";
            }
            else if (makerCode == "PQ") // PopCap Games
            {
                textBoxGameID.Text += "PQ";
            }
            else if (makerCode == "PS") // Bplus
            {
                textBoxGameID.Text += "PS";
            }
            else if (makerCode == "PT") // Firemint
            {
                textBoxGameID.Text += "PT";
            }
            else if (makerCode == "PU") // Pub Company
            {
                textBoxGameID.Text += "PU";
            }
            else if (makerCode == "PV") // Pan Vision
            {
                textBoxGameID.Text += "PV";
            }
            else if (makerCode == "PY") // Playstos Entertainment
            {
                textBoxGameID.Text += "PY";
            }
            else if (makerCode == "PZ") // GameMill Publishing
            {
                textBoxGameID.Text += "PZ";
            }
            else if (makerCode == "Q2") // Santa Entertainment
            {
                textBoxGameID.Text += "Q2";
            }
            else if (makerCode == "Q3") // Asterizm
            {
                textBoxGameID.Text += "Q3";
            }
            else if (makerCode == "Q4") // Hamster
            {
                textBoxGameID.Text += "Q4";
            }
            else if (makerCode == "Q5") // Recom
            {
                textBoxGameID.Text += "Q5";
            }
            else if (makerCode == "QA") // Miracle Kidz
            {
                textBoxGameID.Text += "QA";
            }
            else if (makerCode == "QC") // Kadokawa Shoten / Enterbrain
            {
                textBoxGameID.Text += "QC";
            }
            else if (makerCode == "QH") // Virtual Play Games
            {
                textBoxGameID.Text += "QH";
            }
            else if (makerCode == "QK") // MACHINE Studios
            {
                textBoxGameID.Text += "QK";
            }
            else if (makerCode == "QM") // Object Vision Software
            {
                textBoxGameID.Text += "QM";
            }
            else if (makerCode == "QQ") // Gamelion
            {
                textBoxGameID.Text += "QQ";
            }
            else if (makerCode == "QR") // Lapland Studio
            {
                textBoxGameID.Text += "QR";
            }
            else if (makerCode == "QT") // CALARIS
            {
                textBoxGameID.Text += "QT";
            }
            else if (makerCode == "QU") // QubicGames
            {
                textBoxGameID.Text += "QU";
            }
            else if (makerCode == "QV") // Ludia
            {
                textBoxGameID.Text += "QV";
            }
            else if (makerCode == "QW") // Kaasa Solution
            {
                textBoxGameID.Text += "QW";
            }
            else if (makerCode == "QX") // Press Play
            {
                textBoxGameID.Text += "QX";
            }
            else if (makerCode == "QZ") // Hands-On Mobile
            {
                textBoxGameID.Text += "QZ";
            }
            else if (makerCode == "RA") // Office Create
            {
                textBoxGameID.Text += "RA";
            }
            else if (makerCode == "RG") // Ronimo Games
            {
                textBoxGameID.Text += "RG";
            }
            else if (makerCode == "RH") // h2f Games
            {
                textBoxGameID.Text += "RH";
            }
            else if (makerCode == "RM") // Rondomedia
            {
                textBoxGameID.Text += "RM";
            }
            else if (makerCode == "RN") // Mastiff / N3V Games
            {
                textBoxGameID.Text += "RN";
            }
            else if (makerCode == "RQ") // GolemLabs & Zoozen
            {
                textBoxGameID.Text += "RQ";
            }
            else if (makerCode == "RS") // Brash Entertainment
            {
                textBoxGameID.Text += "RS";
            }
            else if (makerCode == "RT") // RTL Enterprises
            {
                textBoxGameID.Text += "RT";
            }
            else if (makerCode == "RV") // bitComposer Games
            {
                textBoxGameID.Text += "RV";
            }
            else if (makerCode == "RW") // RealArcade
            {
                textBoxGameID.Text += "RW";
            }
            else if (makerCode == "RX") // Reflexive Entertainment
            {
                textBoxGameID.Text += "RX";
            }
            else if (makerCode == "RZ") // Akaoni Studio
            {
                textBoxGameID.Text += "RZ";
            }
            else if (makerCode == "S5") // SouthPeak Games
            {
                textBoxGameID.Text += "S5";
            }
            else if (makerCode == "SH") // Sabarasa
            {
                textBoxGameID.Text += "SH";
            }
            else if (makerCode == "SJ") // Cosmonaut Games
            {
                textBoxGameID.Text += "SJ";
            }
            else if (makerCode == "SP") // Blade Interactive Studios
            {
                textBoxGameID.Text += "SP";
            }
            else if (makerCode == "SQ") // Sonalysts
            {
                textBoxGameID.Text += "SQ";
            }
            else if (makerCode == "SR") // SnapDragon Games
            {
                textBoxGameID.Text += "SR";
            }
            else if (makerCode == "SS") // Sanuk Games
            {
                textBoxGameID.Text += "SS";
            }
            else if (makerCode == "ST") // Stickmen Studios
            {
                textBoxGameID.Text += "ST";
            }
            else if (makerCode == "SU") // Slitherine
            {
                textBoxGameID.Text += "SU";
            }
            else if (makerCode == "SV") // SevenOne Intermedia
            {
                textBoxGameID.Text += "SV";
            }
            else if (makerCode == "SZ") // Storm City Games
            {
                textBoxGameID.Text += "SZ";
            }
            else if (makerCode == "TH") // Kolkom
            {
                textBoxGameID.Text += "TH";
            }
            else if (makerCode == "TJ") // Broken Rules
            {
                textBoxGameID.Text += "TJ";
            }
            else if (makerCode == "TK") // Tasuke / Works
            {
                textBoxGameID.Text += "TK";
            }
            else if (makerCode == "TL") // Telltale Games
            {
                textBoxGameID.Text += "TL";
            }
            else if (makerCode == "TR") // Tetris Online
            {
                textBoxGameID.Text += "TR";
            }
            else if (makerCode == "TS") // Triangle Studios
            {
                textBoxGameID.Text += "TS";
            }
            else if (makerCode == "TV") // Tivola
            {
                textBoxGameID.Text += "TV";
            }
            else if (makerCode == "TW") // Two Tribes
            {
                textBoxGameID.Text += "TW";
            }
            else if (makerCode == "TY") // teyon
            {
                textBoxGameID.Text += "TY";
            }
            else if (makerCode == "UB") // Curve Digital / Facepalm Games
            {
                textBoxGameID.Text += "UB";
            }
            else if (makerCode == "UC") // Digital Lounge
            {
                textBoxGameID.Text += "UC";
            }
            else if (makerCode == "UE") // Mobot Studios
            {
                textBoxGameID.Text += "UE";
            }
            else if (makerCode == "UG") // Data Design Interactive / Popcorm Arcade / Metro 3D
            {
                textBoxGameID.Text += "UG";
            }
            else if (makerCode == "UH") // Intenium Console
            {
                textBoxGameID.Text += "UH";
            }
            else if (makerCode == "UJ") // Ghostlight
            {
                textBoxGameID.Text += "UJ";
            }
            else if (makerCode == "UK") // iFun4all
            {
                textBoxGameID.Text += "UK";
            }
            else if (makerCode == "UN") // Chillingo
            {
                textBoxGameID.Text += "UN";
            }
            else if (makerCode == "UP") // EnjoyUp Games
            {
                textBoxGameID.Text += "UP";
            }
            else if (makerCode == "UR") // Sudden Games
            {
                textBoxGameID.Text += "UR";
            }
            else if (makerCode == "US") // USM
            {
                textBoxGameID.Text += "US";
            }
            else if (makerCode == "UU") // Onteca
            {
                textBoxGameID.Text += "UU";
            }
            else if (makerCode == "UV") // Fugazo
            {
                textBoxGameID.Text += "UV";
            }
            else if (makerCode == "UW") // Coresoft
            {
                textBoxGameID.Text += "UW";
            }
            else if (makerCode == "VB") // PadaOne Games
            {
                textBoxGameID.Text += "VB";
            }
            else if (makerCode == "VC") // Frima Studio
            {
                textBoxGameID.Text += "VC";
            }
            else if (makerCode == "VG") // Vogster Entertainment
            {
                textBoxGameID.Text += "VG";
            }
            else if (makerCode == "VK") // Sandlot Games
            {
                textBoxGameID.Text += "VK";
            }
            else if (makerCode == "VL") // Eko Software
            {
                textBoxGameID.Text += "VL";
            }
            else if (makerCode == "VN") // Valcon Games
            {
                textBoxGameID.Text += "VN";
            }
            else if (makerCode == "VP") // Virgin Play
            {
                textBoxGameID.Text += "VP";
            }
            else if (makerCode == "VS") // Korner Entertainment
            {
                textBoxGameID.Text += "VS";
            }
            else if (makerCode == "VT") // Microforum Games
            {
                textBoxGameID.Text += "VT";
            }
            else if (makerCode == "VU") // Double Jungle
            {
                textBoxGameID.Text += "VU";
            }
            else if (makerCode == "VV") // Pixonauts
            {
                textBoxGameID.Text += "VV";
            }
            else if (makerCode == "VW") // Image & Form
            {
                textBoxGameID.Text += "VW";
            }
            else if (makerCode == "VX") // Frontline Studios
            {
                textBoxGameID.Text += "VX";
            }
            else if (makerCode == "VZ") // Little Orbit
            {
                textBoxGameID.Text += "VZ";
            }
            else if (makerCode == "WD") // Amazon
            {
                textBoxGameID.Text += "WD";
            }
            else if (makerCode == "WG") // 2D Boy
            {
                textBoxGameID.Text += "WG";
            }
            else if (makerCode == "WH") // NinjaBee
            {
                textBoxGameID.Text += "WH";
            }
            else if (makerCode == "WI") // Curve Digital
            {
                textBoxGameID.Text += "WI";
            }
            else if (makerCode == "WJ") // Studio Walljump
            {
                textBoxGameID.Text += "WJ";
            }
            else if (makerCode == "WL") // Wired Productions
            {
                textBoxGameID.Text += "WL";
            }
            else if (makerCode == "WN") // tons of bits
            {
                textBoxGameID.Text += "WN";
            }
            else if (makerCode == "WP") // White Park Bay Software
            {
                textBoxGameID.Text += "WP";
            }
            else if (makerCode == "WQ") // Revistronic
            {
                textBoxGameID.Text += "WQ";
            }
            else if (makerCode == "WR") // Warner Bros. Interactive Entertainment
            {
                textBoxGameID.Text += "WR";
            }
            else if (makerCode == "WS") // MonkeyPaw Games
            {
                textBoxGameID.Text += "WS";
            }
            else if (makerCode == "WW") // Slang Publishing
            {
                textBoxGameID.Text += "WW";
            }
            else if (makerCode == "WY") // WayForward Technologies
            {
                textBoxGameID.Text += "WY";
            }
            else if (makerCode == "WZ") // Wizarbox
            {
                textBoxGameID.Text += "WZ";
            }
            else if (makerCode == "X0") // SDP Games
            {
                textBoxGameID.Text += "X0";
            }
            else if (makerCode == "X3") // CK Games
            {
                textBoxGameID.Text += "X3";
            }
            else if (makerCode == "X4") // Easy Interactive
            {
                textBoxGameID.Text += "X4";
            }
            else if (makerCode == "X9") // Renegade Kid
            {
                textBoxGameID.Text += "X9";
            }
            else if (makerCode == "XB") // Hulu
            {
                textBoxGameID.Text += "XB";
            }
            else if (makerCode == "XG") // XGen Studios
            {
                textBoxGameID.Text += "XG";
            }
            else if (makerCode == "XJ") // XSEED Games
            {
                textBoxGameID.Text += "XJ";
            }
            else if (makerCode == "XK") // Exkee
            {
                textBoxGameID.Text += "XK";
            }
            else if (makerCode == "XM") // DreamBox Games
            {
                textBoxGameID.Text += "XM";
            }
            else if (makerCode == "XN") // Netflix
            {
                textBoxGameID.Text += "XN";
            }
            else if (makerCode == "XS") // Aksys Games
            {
                textBoxGameID.Text += "XS";
            }
            else if (makerCode == "XT") // Funbox Media
            {
                textBoxGameID.Text += "XT";
            }
            else if (makerCode == "XU") // Shanblue Interactive
            {
                textBoxGameID.Text += "XU";
            }
            else if (makerCode == "XV") // Keystone Game Studio
            {
                textBoxGameID.Text += "XV";
            }
            else if (makerCode == "XW") // Lemon Games
            {
                textBoxGameID.Text += "XW";
            }
            else if (makerCode == "XY") // Gaijin Games
            {
                textBoxGameID.Text += "XY";
            }
            else if (makerCode == "Y1") // Tubby Games
            {
                textBoxGameID.Text += "Y1";
            }
            else if (makerCode == "Y4") // Zen Studios
            {
                textBoxGameID.Text += "Y4";
            }
            else if (makerCode == "Y5") // Easy Interactive
            {
                textBoxGameID.Text += "Y5";
            }
            else if (makerCode == "Y6") // Motiviti
            {
                textBoxGameID.Text += "Y6";
            }
            else if (makerCode == "Y7") // The Learning Company
            {
                textBoxGameID.Text += "Y7";
            }
            else if (makerCode == "Y9") // RadiationBurn
            {
                textBoxGameID.Text += "Y9";
            }
            else if (makerCode == "YC") // NECA
            {
                textBoxGameID.Text += "YC";
            }
            else if (makerCode == "YD") // Infinite Dreams
            {
                textBoxGameID.Text += "YD";
            }
            else if (makerCode == "YF") // O2 Games
            {
                textBoxGameID.Text += "YF";
            }
            else if (makerCode == "YG") // Maximum Family Games
            {
                textBoxGameID.Text += "YG";
            }
            else if (makerCode == "YJ") // Frozen Codebase
            {
                textBoxGameID.Text += "YJ";
            }
            else if (makerCode == "YK") // MAD Multimedia
            {
                textBoxGameID.Text += "YK";
            }
            else if (makerCode == "YM") // Bergsala Lightweight
            {
                textBoxGameID.Text += "YM";
            }
            else if (makerCode == "YN") // Game Factory
            {
                textBoxGameID.Text += "YN";
            }
            else if (makerCode == "YR") // Cypronia
            {
                textBoxGameID.Text += "YR";
            }
            else if (makerCode == "YS") // Yullaby
            {
                textBoxGameID.Text += "YS";
            }
            else if (makerCode == "YT") // Corecell Technology
            {
                textBoxGameID.Text += "YT";
            }
            else if (makerCode == "YV") // KnapNok Games
            {
                textBoxGameID.Text += "YV";
            }
            else if (makerCode == "YX") // Selectsoft
            {
                textBoxGameID.Text += "YX";
            }
            else if (makerCode == "YY") // FDG Entertainment
            {
                textBoxGameID.Text += "YY";
            }
            else if (makerCode == "Z4") // Ntreev Soft
            {
                textBoxGameID.Text += "Z4";
            }
            else if (makerCode == "Z5") // Shinsegae I&C
            {
                textBoxGameID.Text += "Z5";
            }
            else if (makerCode == "ZA") // WBA Interactive
            {
                textBoxGameID.Text += "ZA";
            }
            else if (makerCode == "ZG") // Zallag
            {
                textBoxGameID.Text += "ZG";
            }
            else if (makerCode == "ZH") // Internal Engine
            {
                textBoxGameID.Text += "ZH";
            }
            else if (makerCode == "ZJ") // Performance Designed Products
            {
                textBoxGameID.Text += "ZJ";
            }
            else if (makerCode == "ZK") // Anima Game Studio
            {
                textBoxGameID.Text += "ZK";
            }
            else if (makerCode == "ZP") // Fishing Cactus
            {
                textBoxGameID.Text += "ZP";
            }
            else if (makerCode == "ZS") // Zinkia Entertainment
            {
                textBoxGameID.Text += "ZS";
            }
            else if (makerCode == "ZV") // RedLynx
            {
                textBoxGameID.Text += "ZV";
            }
            else if (makerCode == "ZW") // Judo Baby
            {
                textBoxGameID.Text += "ZW";
            }
            else if (makerCode == "ZX") // TopWare Interactive
            {
                textBoxGameID.Text += "ZX";
            }
    }
}
