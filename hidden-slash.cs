
using System;

class Program
{
    public static void Main(string[] args)
    {
    
        string again;

        do
        {
            string[] letters = { "t", "c", "s", "r", "k", "o", "e" };
            string stringWithSlashes = "///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////\n///////////////////////////////////////////////////////////////////////////";        
    
            // All the randomness

            Random rng = new Random();
    
            int rngIndex = rng.Next(0, letters.Length);
            int slashIndex = rng.Next(0, stringWithSlashes.Length);
    
            // Convert the string to an array of characters so that you can edit the elements individually.

            char[] charArray = stringWithSlashes.ToCharArray();
    
            // Replace the slash at the random index with a random letter.

            charArray[slashIndex] = Convert.ToChar(letters[rngIndex]);
    
            Console.WriteLine("Find the letter and write it down:\n");

            Console.WriteLine(new string(charArray));
    
            Console.WriteLine("\nWrite it down at the bottom:");
            string input = Console.ReadLine();
    
            // See if it's right.

            while (input != letters[rngIndex])
            {
                Console.WriteLine("You're wrong");
                Console.WriteLine("Try again:");
                input = Console.ReadLine();
            }

            // The letter that corresponds to the animal.
    
            switch (input)
            {
                case "t":
                    Console.WriteLine (@"
                    Tigre
                            
                         _______                       _______
                       ,' ,----. `.                  ,' ,----. `.
                      ,','\\ \\\`.`. ___,------.___ ,' ' /////`. ;
                      : .\ \\\ \   `' ,...::  :... `' '/// ////; :
                      `.`.\\\\\:    ,:: ...  ... `::::. /////.' .'
                       `._`. ::  ___    '      `  ___    ;  ',-'
                          `-,  ,'(_)`,  .     . .'(_)`; :;  '
                           ;   :     ;    . .   :     : ;;  `.
                         ,' .:  `---'`          '`---' .'  ;  `.
                       ,': :.        '  /    \   `        ;; :: `.
                      , ;: `::::       / :  : \        ..:'   :: `,
                      : ::       ,'   (`------')    `.         ;  ;
                      :         ;    . `------'   .   ` `.    ;;  ;
                      `.`:.   ; `.  . .   _;_    . . ,'  ::   :; ,
                       `.`::.  ;  `.____.'___`.____,'    `::  ; ,'
                        `. `:.           `~~~'         ;       .'
                          `.         `.__________.'     ;     .'
                            `....  :.   .::.::.:.   ..::  ... '
                              _,-'                       `-._
                           ,-'..:::::.            .::::..    `-.
                          ,'        `:::.       .:::'    ..:::::.
                          :            :::     :::'   .::'    `:`.
                         ;,::::.       `::: ..;:'      '         :        _
                         :    `:::.     `::               .::..  `.   ,--' `-.
                        :             , ,        ,      .::       :\_/;     :::.
                        .             ` `      , `,   .::'        `  ::    ::: `.
                        `.     ;::::::: ` ,   ,`, ` :::'          : ::   :::    `:
                        `.    ;;       :: `   ` ` ::         ::::,'     ::       :
                         :   ..            \/\/            ,:::::й ;    :     .::й
                         :                 }##{.      ,:::::::::,' '        .::  ;
                         :                `###,'     ::::'     : //        ::   .'
                          :  ,::::.        :#:     .:::       ,'/ '             ;
                          `::::   `:::     :#:          ,:    й /:         ::  .'
                          `.               й#`,      ,::: :: ,'  `.       :: ::;
                           `.    .::.      :##:     :::    : :// /`.         : '
                            `.       ::   ,'##:   .:         :/  //`         .'
                             `.       `...:###`.            ,//  ,'    ..:::.'    ,'
                              `.    ..    й####;  :::.   ,  :///,'         ,'   ,'
                              :       `:::;####:.::      ` ,'// ;         ,'`--'::
                        ____.'           .'### :         , :// ...:  ..:::`.  ::
                    ,--'__   ,         ));     `. )      ` :~~,''          `.  ::,-'
                    `-,' __,-  ,         ;    _,-'        , : ;             `.--'
                     !--й    ,--     _;--' _,-'            `  )(!_)(!_)(!_)(!_)
                        `!---;_!__-'     ;    ,'  ,' ,'   _,-' ~   ~   ~   ~
                               ~         `!---(!_(!_(!___(
                                               ~  ~  ~");
                    break;
                case "c":
                    Console.WriteLine (@"
                    Cerf
                            
                                         ,
                           ,   , |-_      ,           ,  ,
                          (_  ,' ( \)  :  |           ' ,'
                            \_(  ( :| _,_,'     ''',  ;,'
                          ,   '\_\\ ',-'          ,', ,,    ,
                         ,'  ,   '\ ,| ,           ''_.',   ',  ,
                      .' ,  ',:   )\ |,'           '-- (     ',-'
                      ',,'    ':_;)_,'\               ) \__,,-'
                    (__(:_ ,      \ ,  \_            / ,--''
                        \_,'_,     \\ /''-,        __) )
                          '._',__ ._\(_   ____,--''_,-'
                        (_') (   )(  /_''',___,--''--.'
                          / __===((_(_)  (,  ;
                         (/'  , 7,---.__,  _;    
                            _,-   __   (     --..___..----.........--------____---._  _
                       _,--       ;O ) )))  `` :.``:.` `` ``` `  ``  .``` . .. ; . .::  :=
                      (( (  7/,,  `  )  :      : ` : `        .      . `` . .. ; ::..:  :)\
                       \__'__,._  ,,,      :               :    .      . `` . .. ;: .. : :((\
                                ----,      :              :.     .    .  `` . ..; . :.:  :  `
                                    \;;     :           ::.       .   .    `` : .:. : .: ;
                                    |; ;     :        ...:        .       , ;;:. ;. : . :;
                                    |;  ;     ::    ..::`        .     , ,,;;;) ;. : ..:;:
                                    ;;   ;;      ..::` ;;;  ,  ,   ,  ,  ,;;;;) . : ..:; :
                                    `;;    ;;;  :::``;;; ;;;,,;;,;;,,;;,;;;;;( ; .. :.; (
                                     `;;;     __    :: (;;;;;;;;;;;;;;;;;;;;;_\  ; ;. ; :
                                      `;;;;;;`;: \ ;;:/--`````````````-----    \;;;. / :(
                                        ```` \:::|;;;/                          \;;;;| :\
                                              |::;;;;;                            :;;;|::\
                                              ::;\;;;;                             :;;\::(
                                              ::; \;;|                             \;;(:::)
                                              |:; |;;|                             );;)|::/
                                              /:: \;;;                             ;;/ \:|
                                              ;:: |;;)                            ;;|  ;:|
                                              ;::  ;;|                            ;;|  ;:|
                                             ./:;  /;|                           ;;/   ;:|
                                           _.;:(  /;(                         _./:(   _;:(
                                          ;__;-\`;_;_\\                      ;__;-\  ;;_;\\");
                    break;
                case "s":
                    Console.WriteLine(@"
                    Singe
                    
                                ,.-----.,
                               /   ===   \
                              /  =======  \
                           __|  (0)   (0)  |__      
                          / _|    .---.    |_ \         
                         | /.----/ O O \----.\ |       
                          \/     |     |     \/        
                          |                   |            
                          |                   |           
                          |                   |          
                          _\   -.,_____,.-   /_         
                      ,.---  ---.,_________,.----.,
                     /          |       |          \  
                    |           l.     .l           | 
                    |            |     |            |
                    l.           |     |           .l             
                     |           l.   .l           | \,     
                     l.           |   |           .l   \,    
                      |           |   |           |      \,  
                      l.          |   |          .l        |
                       |          |   |          |         |
                       |          |---|          |         |
                       |          |   |          |         |
                       /---.,__,.-\   /---.,__,.--\---,_,.--\
                      |            \ /            |         |
                      |             |             |         |
                       \__|__|__|__/ \__|__|__|__/ \_|__|__/");
                    break;
                case "r":
                    Console.WriteLine (@"
                    Rhinocéros
                            
                                  _                 __                 
                          __.--**   **--...__..--**    *-.            
                        .'                                `-.         
                      .'                         _           \        
                     /                         .'        .    \   _._ 
                    :                         :          :`*.  :-'.' ;
                    ;    `                    ;          `.) \   /.-' 
                    :     `                             ; ' -*   ;    
                     \      :.    \           :       :  :        :    
                     ;     ; `.   `.         ;     ` |  '       |      
                     |         `.            `. -* *\; /        :     
                     |    :     /`-.           `.    \/`.'  _    `.   
                     :    ;    :    `*-.__.-*---:`.   \ ;  'o` `. /   
                     \     ;   ;                ;  \   ;:       ;:   ,/
                      |  | |                       /`  | ,      `*-*'/ 
                      `  : :  :                /  /    | : .    ._.-'  
                       \  \ ,  \              :   `.   :  \ \   .'     
                        :  *:   ;             :    |`*-'   `*+-*       
                        `**-*`                 *---*");
                    break;
                case "k":
                    Console.WriteLine (@"
                    Kangourou
        
                             /\ /l
                            ((.Y(!
                             \ |/
                             /  6~6,
                             \ _    +-.
                              \`-=--^-'
                               \ \
                              _/  \
                            (  .  Y
                            / \ `--^--v--.
                           / _ `-- T~\/~\/
                          /   ~\.  !
                    _    Y      Y./'
                   Y^|   |      |~~7
                   | l   |     / ./'
                      | `L  | Y .^/~T
                   |  l  ! | |/| |
                   | .`\/' | Y | !
                   l   ~   j l j_L______
                    \,____{ __ ~ __ ,\_,\_");
                    break;
                case "o":
                Console.WriteLine (@"
                Oiseau
                        
                                                    /T /I          
                                              / |/ | .-~/    
                                          T\ Y  I  |/  /  _  
                         /T               | \I  |  I  Y.-~/  
                        I l   /I       T\ |  |  l  |  T  /   
                 __  | \l   \l  \I l __l  l   \   `  _. |    
                 \ ~-l  `\   `\  \  \\ ~\  \   `. .-~   |    
                  \   ~-. -.  `  \  ^._ ^. -.  /  \   |    
                    \-._  ~-  `  _  ~-_.- ._ /._ .   /  
                     >--.  ~-.   ._  ~>-     \\   7   ]    
                ^.___~--._    ~-{  .-~ .  `\ Y . /    |     
                 <__ ~-.  ~       /_/   \   \I  Y   : |
                   ^-.__           ~(_/   \   >._:   | l____     
                       ^--.,___.-~  /_/   !  `-.~--l_ /     \~-.  
                              (_/ .  ~(   /'     ~--,Y   -=b-. _) 
                               (_/ .  \  :           / l      c~o \
                                \ /    `.    .     .^   \_.-~~--.  ) 
                                 (_/ .   `  /     /       !       )/  
                                  / / _.   '.   .':      /        ' 
                                  ~(_/ .   /    _  `  .-<_  
                                    /_/ . ' .-~ `.  / \  \          ,z=.
                                    ~( /   '  :   | K   -.~-.______//
                                      -,.    l   I/ \_    __{--->._(==.
                                       //(     \  <    ~~     //
                                      /' /\     \  \     ,v=.  ((
                                    .^. / /\       }__ //===-  `
                                   / / ' '  -.,__ {---(==-
                                 .^ '       :  T  ~   ll
                                / .  .  . : | :!        \\ 
                               (_/  /   | | j-          ~^
                                 ~-<_(_.^-~  ");
                    break;
                case "e":
                    Console.WriteLine (@"
                    Elephant
            
                                              .' `'.__
                                             /      \ `'--,
                            .-''''--...__..-/ .     |      \
                          .'               ; :'     '.  a   |
                         /                 | :.       \     =\
                        ;                   \':.      /  ,-.__;.-;`
                       /|     .              '--._   /-.7`._..-;`
                      ; |       '                |`-'      \  =|
                      |/\        .   -' /     /  ;         |  =/
                      (( ;.       ,_  .:|     | /     /\   | =|
                       ) / `\     | `--;     / |    | /   / =/
                         | ::|    |      \    \ \    \ `--' =/
                        /  '/\    /       )    |/     `-...-`
                       /    | |  `\    /-'    /;
                       \  ,,/ |    \   D    .'  \
                        `--`   \ _nnh  D_.-'L__nnh");
                    break;
            }

            // Sentences to start over.

            Console.WriteLine("\nDo you want to do it all over again? [y or n]");
            again = Console.ReadLine();
        }while(again == "y");
    }
}