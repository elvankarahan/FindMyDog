using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FindMyDog
{
    class DogsViewModel : ObservableObject
    {

        public IList<Dog> Dogs2 { get; set; }

        /// --------------------////
        private Dog _selectedDog;
        public Dog SelectedDog
        {
            get { return _selectedDog; }
            set { SetProperty<Dog>(ref _selectedDog, value); }
        }
        /// --------------------////

        public DogsViewModel()
        {

            GlobalVariables.Dogs = new ObservableCollection<Dog>()
            {
                new Dog()
                {
                    Name = "Afghan hound",
                    GroupName = "Hound Dogs",
                    Height = "25-27 inches",
                    Weight = "50-60 pounds",
                    LifeSpan = "12-18 years",
                    CoverImage = "AfghanHound.jpg",
                    Info = "The Afghan Hound was originally used for hunting large prey in both the deserts and in the mountains of Afghanistan, where his abundant, flowing coat was needed for warmth. The Afghan was highly valued for his ability to run — fast and over great distances — courageously holding dangerous animals, such as leopards, at bay until his huntsman on horseback caught up. The Afghan was also valued for his ability to think and hunt independently, without human direction. \n"
                    + "\n Today's Afghan Hound isn't hunting leopards but this sighthound does retain the independent nature of a coursing hound. An Afghan puppy will eagerly seek affection from family members, just like puppies of any breed, but this puppyhood behavior can fool unsuspecting owners. Cute puppy antics diminish as the Afghan matures. A mature Afghan Hound does not lavish attention on anyone, and sometimes doen't even want to be hugged or petted. The free-thinking, independent Afghan will decide for himself when he wants affection, and it will be on his terms — not yours. \n"
                    + "\n Independence and indifference aside, the Afghan Hound is tender when he wishes to be and can be very amusing. Often referred to as a 'clown' by his affectionate family, the Afghan Hound is known to be mischievous and stories abound of this breed's ability to steal objects from under the very noses of family members, even going so far as to open dresser drawers and snatch clothes. \n"
                    + "\n With an ability to see far greater distances than humans and pivotal hip joints that enable him to cover ground quickly and easily clear obstacles, the Afghan is a natural for a sport called lure coursing. In lure coursing, the hounds give chase to plastic bags that are used to create the effect of escaping game. This competition tests the dog's ability to hunt by sight, and basic coursing instinct. In 1972, the American Sighthound Field Association (ASFA) began, and continues to operate and oversee a program much loved by owners and dogs alike. \n"
                    + "\n Whether competing in a coursing event, or enjoying life as a playful family companion, the Afghan Hound is a one-of-a-kind breed."
                },

                new Dog()
                {
                    Name = "Airedale",
                    GroupName = "Terrier Dogs",
                    Height = "23 inches",
                    Weight = "50-70 pounds",
                    LifeSpan = "11-14 years",
                    CoverImage = "Airedale.jpg",
                    Info = " During World War I, a hardy Airedale Terrier named Jack braved the battlefields to deliver a message to British headquarters. Running through a half-mile of swamp, artillery raining down on him, Jack suffered a shattered leg and broken jaw. Sadly, he passed away soon after he'd completed his mission. Incredibly, the message he was carrying saved his battalion and he was posthumously awarded the Victoria Cross for 'Gallantry in the Field.' The bravery and courage exhibited by Jack holds true for today's Airedales.\n"
                    + "\n Dogs like Jack were bred as a multi-purpose dog who had the keenness of a terrier, but could swim and smell prey. Airedale Terriers have the distinction of being both a sporting and working dog, and today compete in agility, obedience, and hunt tests. \n"
                    + "\n They enjoy life the most when there is a job to be done, even if it is simply entertaining children, with whom he gets along splendidly. (Nevertheless, an adult should always supervise interactions between kids and dogs.)\n"
                    + "\n Like all terriers, the Airedale has a penchant for digging, chasing, and barking. He is full of energy and makes an excellent jogging companion. Daily walks and romps in the yard are among his favorite activities. \n"
                    + "\n You can't talk about the Airedale without mentioning his independent streak. This is an intelligent dog who thinks for himself and does not always wait for direction from his owner. If you want a highly biddable dog that awaits your every command, the Airedale Terrier is not the breed for you. However, if you are stimulated by challenge, living with an Airedale may suit you.\n"
                    + "\n It's worth mentioning that the Airedale Terrier is unforgiving of any harsh treatment and will hold a grudge against the aggressor. He can be aggressive to other dogs and animals, and has a strong prey drive, which makes him difficult to handle at times. It is said that the Airedale doesn't start fights — he finishes them. Consistent, positive obedience training is a must, as is a securely fenced yard. \n"
                    + "\n Not surprisingly, the Airedale is an excellent watchdog. He will protect his family from intruders with fierce and brave loyalty. However, he is friendly to invited guests in his home.\n"
                    + "\n Make no mistake: The Airedale isn't all business — his flipside is comical and playful. He enjoys the company of his family, and he loves romping and playing, tossing toys, stealing dirty socks, grabbing food off the kitchen counter, and just generally creating mischief. He matures slowly, and is often puppyish well into old age.\n"
                    + "\n The Airedale is a fascinating breed. He's courageous and athletic, stylish and silly. Many owners say that the only thing better than one Airedale Terrier is two.\n"
                },

                new Dog()
                {
                    Name = "Australian terrier",
                    GroupName = "Terrier Dogs",
                    Height = "10-11 inches",
                    Weight = "15-20 pounds",
                    LifeSpan = "11-15 years",
                    CoverImage = "AustralianTerrier.jpg",
                    Info = "The Australian Terrier, called an 'Aussie' by his admirers (although he's not to be confused with an Australian Shepherd), is a small terrier with upright ears and a rough, shaggy coat. He is the littlest of the working terriers, but don't let his size fool you. He's definitely a lot of dog in a tiny package, with a typical terrier slant on life: tenacious, independent, hardworking, and lively.\n"
                    + "\n With a spirited, mischievous personality, the Aussie jumps into life with attitude. But he's usually strongly attached to his family — so strongly attached that he'll often match his mood to yours. If you've got the blues, he is calm and quiet. If you're happy and excited, he turns frisky and playful. \n"
                    + "\n Mostly, the Aussie is upbeat, active, and silly, clowning around and entertaining his owners. He has an affinity for the young, the elderly, and the disabled. He makes an excellent playmate for a child, although adults should supervise interactions with very young children: Australian Terriers are not snappy or aggressive, but they do have limits on the handling and roughhousing they will tolerate.\n"
                    + "\n He may be small, but the Australian Terrier has the confidence of a large breed. He is a wonderful watchdog and will bark to alert his owners of the approach of anyone or anything new and different. \n"
                    + "\n Since they're so intelligent, Australian Terriers will readily learn whatever you're teaching (so be sure you don't inadvertently teach your Aussie pup that it's okay to jump up on you or chase the cat — or he'll keep up the behavior throughout his adulthood as well). Repetitive training is a bore for these bundles of energy, so lessons must be fun and increasingly challenging. Also, the independent Aussie likes to think the schooling is all his idea. Positive, reward-based training works wonders.\n"
                    + "\n Since the breed was developed as a working terrier, the Aussie instinct to chase and kill small animals — including squirrels, rabbits, mice, and cats — is strong. A securely fenced yard is essential, as is leash training. If you have rodents or other small pets, you need to introduce your Aussie to them when he's a young puppy, and teach him from the start that they are off limits. This can be very difficult — in truth, the best strategy is to never allow the Aussie to gain access to them. He can live with cats if he grows up with them and is taught to leave them alone, but he's likely to consider all felines outside your household to be fair game.\n"
                    + "\n If you like a pristine lawn or showplace garden, an Australian Terrier may not be the breed for you. Like all terriers, he loves to dig — it's in his breeding — and if left unsupervised for too long, he'll decide that tearing up the lawn is an ideal way to amuse himself.\n"
                    + "\n Even though he stands a mere 10 inches tall and weighs about 14 pounds, this is one confident breed. The spunky Aussie will challenge other dogs, including those much bigger than he is. He can be aggressive and bossy to other dogs in his household.\n"
                },

                new Dog()
                {
                    Name = "Basset",
                    GroupName = "Hound Dogs",
                    Height = "up to 15 inches",
                    Weight = "40-65 pounds",
                    LifeSpan = "12-13 years",
                    CoverImage = "Basset.jpg",
                    Info = "He may be best known as the Hush Puppy dog, but the Basset Hound is much more than an advertising icon. With his placid personality and short-statured yet noble appearance, the Basset Hound is a popular family companion, as well as a slow-paced but keen hunting dog.\n"
                    + "\n The name Basset comes from the French word bas, meaning low. And Basset Hounds certainly are low to the ground. Because their bones are heavy and they are muscular, they usually weigh 50 to 65 pounds although they typically are no more than 14 inches tall at the highest point of the shoulder. In reality, they are big dogs on short legs. Their short-legged appearance is the result of a form of dwarfism called achondroplasia. Despite his large size, the Basset believes he's a lap dog and will do his best to fit in yours.\n"
                    + "\n Bassets are scent hounds, meaning that they were bred to hunt by following the scent of their prey. Their phenomenal sense of smell is second only to that of the Bloodhound.\n"
                    + "\n Basset Hounds have smooth, short, hard-textured coats that are relatively easy to take care of. Most of them come in the classic tri-color pattern of black, tan, and white, but they can also be what's known as open red and white (red spots on a white coat), closed red and white (solid red with white feet and tail), or lemon and white. On occasion you may see a gray (also called blue) Basset, but this color is considered undesirable because it's thought to be associated with genetic problems.\n"
                    + "\n The Basset Hound has a rounded skull with a deep muzzle and a lot of loose skin on the face, which is heavily wrinkled over the brow when the dog is tracking. This loose skin also causes Bassets to have a sad look, which many people think adds to their charm.\n"
                    + "\n Because they were originally bred to be hunting dogs, many of the features of the Basset Hounds have a purpose. Their long, low-set ears drag the ground and pick up scents, while the loose skin around their heads form wrinkles that further capture the scent of whatever they are tracking.\n"
                    + "\n Their short legs mean that they move more slowly than longer-legged dogs, which makes it easier for hunters on foot to follow them. Their tails are long and stand upright with a white tip at the end, which makes it easy for hunters to see when the dogs are in tall grass. Basset Hounds also have massive paws and their front feet turn outward slightly to balance the width of the shoulders.\n"
                    + "\n Around the house, Basset Hounds are calm and rather lazy. They are loyal to their people and have a pleasant, friendly disposition. Because they originally were bred as pack dogs, they love to be with their families and also do well with other pets. Bassets hate to be left alone for long periods of time, and may become destructive and howl if left alone for too long. Their distinctive baying bark is loud and travels long distances.\n"
                    + "\n Basset Hounds are hearty eaters, but because they aren't very active in the house, they can gain weight and quickly become obese, which can cause them to have back and leg problems. Regular exercise is a must. Bassets have a great deal of endurance, so they enjoy taking long walks.\n"
                    + "\n When you're walking your Basset, be aware that he loves to track. If he picks up a scent that he wants to follow, he can wander off if not on leash. Bassets are singleminded when trailing a scent and will follow it into the street in front of a car if they're not leashed or confined by a fence.\n"
                    + "\n Lots of Basset people channel their dogs' superb scent-trailing skills in organized tracking events called basseting, which take place primarily in Virginia, Maryland, New Jersey, and Pennsylvania. Bassets are naturals at earning tracking, hunt test, and field trial titles, but they've also been known to compete successfully in agility, obedience, and rally, given a patient trainer.\n"
                    + "\n Patience is definitely a virtue when it comes to training a Basset. Unless you can persuade him that it's something he wants to do, he can be stubborn and difficult to train. Many Basset Hounds will obey commands when offered food, but won't obey if you don't have a tasty reward to offer them.\n"
                    + "\n Housetraining a Basset is a challenge too, but with patience and persistence, you can train and housetrain your Basset. Just be sure to use gentle, positive training methods. Basset Hounds are emotionally sensitive and will shut down if treated roughly.\n"
                    + "\n Basset Hounds have unique voices. They generally howl (sometimes called a bay) rather than bark. They also have a unique, murmuring whine that they use when they want attention or are begging for food. Thanks to their delightfully imploring expressions, they're often successful at winning treats of Chinese food, pizza, French fries, and other tasty junk food.\n"
                    + "\n Well-bred Bassets are even-tempered, relaxed, and generally happy dogs. They are very gentle with children and other pets. Their biggest faults are their tendency to drool and to howl when lonely or to sound an alarm. If you can tolerate his idiosyncrasies, the Basset can make a wonderful family companion, as happy to lounge around the house as he is to be out hunting.\n"
                },

                new Dog()
                {
                    Name = "Beagle",
                    GroupName = "Hound Dogs",
                    Height = "13-15 inches",
                    Weight = "20-30 pounds",
                    LifeSpan = "10-15 Years",
                    CoverImage = "Beagle.png",
                    Info = "It's difficult to resist the appeal of a Beagle's dark brown or hazel eyes, with his soft, pleading expression. They're happy, outgoing and loving — characteristics more than balanced out by their hound nature, which is inquisitive, determined, and focused on food.\n"
                    + "\n They aren't yappy dogs, but they do have three distinct vocalizations — a bark/growl, a baying howl, and a half-baying howl (a cross between a frantic bark and a bay). The half-howl vocalization usually is reserved for when they catch sight of quarry — or think it's time to wake the neighbors at 6 a.m.! Being pack dogs, they generally get along well with other animals and their human friends — and they think everyone is their new best friend.\n"
                    + "\n The most important thing to know about the Beagle is that he is a scenthound. His nose is the most important part of his anatomy and his head is always down to the ground, searching for an interesting trail to follow. Beagles have approximately 220 million scent receptors compared to the paltry 5 million or so in people, which makes them very good at picking up scents. Humorist Dave Barry once described his in-laws' Beagle as 'a nose with feet.'\n"
                    + "\n You may have seen the Beagle's nose at work at airports across the country. In 1984, the U.S. Department of Agriculture decided to use Beagles to sniff out contraband food being brought into the United States at the Los Angeles International Airport.\n"
                    + "\n The experiment was a huge success. Because they are small, friendly, and cute, the Beagles didn't intimidate people who are afraid of dogs, and with their super nose power, they could be trained to identify specific food articles while bypassing those that weren't contraband. Today, members of the 'Beagle Brigade' patrol the baggage-claim areas at more than 20 international airports and other points of entry into the United States.\n"
                    + "\n Although they've branched out into other fields of work, Beagles remain superb hunters of small game. The National Beagle Club's Institute Farm hosts AKC-sanctioned field trials where breeders with packs are put to the test in the field. Many other countries have similar activities for hunting Beagles.\n"
                    + "\n Because of their small size and gentle temperament, Beagles can do well in apartments if their people are willing to walk them on lead several times a day in all kinds of weather. They need plenty of exercise, about an hour a day if possible. If left alone and unexercised, Beagles can become destructive.\n"
                },

                new Dog()
                {
                    Name = "Bedlington terrier",
                    GroupName = "Terrier Dogs",
                    Height = "15-17 inches",
                    Weight = "17-23 pounds",
                    LifeSpan = "11-16 years",
                    CoverImage = "BedlingtonTerrier.jpg",
                    Info = "The Bedlington Terrier captures your attention with his unique lamblike appearance and keeps it with his entertaining, opinionated personality. Don't let his appearance fool you, however. The Bedlington is all terrier: inquisitive, intelligent, alert, and aggressive toward small animals outdoors.\n"
                    + "\n Bedlingtons throw themselves with enthusiasm into the activities of their family. They love to be the center of attention and will play the clown to get it. Bedlingtons welcome guests and entertain them with their antics, but they'll let you know if they think someone's shady. Bedlington people say their dogs have astute judgment and make excellent watchdogs.\n"
                    + "\n Exercise is important to keep a Bedlington happy and healthy, but he has moderate energy levels and activity needs. He'll match his activity level to yours and can be satisfied with a nice walk or vigorous game of fetch. He can jog with you or go on a hike. Although he's rarely used in the field, his hunting abilities include pointing, retrieving, tracking, and, of course, going to ground after den animals. Whatever you do with him, he's happy to be a couch potato afterward.\n"
                    + "\n When he's raised with children, the Bedlington can be an energetic playmate. Make sure extremely young children are supervised by an adult when interacting with any dog to prevent injury to both. While a Bedlington will tolerate a certain amount of rough handling, he will set limits when things get too rough, and he doesn't understand that a child's skin isn't as tough as another dog's.\n"
                    + "\n Bedlingtons can get along well with other dogs, especially if they're raised with them. Like most terriers, they might not start a fight, but they won't back down from one. The Bedlington may look fluffy and sweet, but he's no pushover and won't accept readily another dog's attempt to dominate him. Bedlingtons can be fierce fighters if aroused, so be cautious when introducing them to new canine companions, especially other adults of the same sex. Male Bedlingtons especially will persist in a fight until major damage is done.\n"
                    + "\n The Bedlington is intelligent, and that intelligence makes him only moderately easy to train. He does best when you can persuade him that doing what you want is really his idea or benefits him in some way. Use positive reinforcement techniques such as praise, play, and food rewards. Harsh words and physical force will not work with this breed, as they will only bring out his stubborn streak and begin a battle of wills that you will probably lose. Nonetheless, Bedlingtons have competed successfully in the obedience ring. They view the agility ring as an excellent opportunity show off their speed, grace, and enthusiasm. And naturally your Bedlington will love Earth Dog competitions in which he can display his terrier tenacity and willingness to find prey underground.\n"
                    + "\n With proper training and socialization, the Bedlington is an excellent companion and enthusiastic partner in all family activities. You will appreciate his sense of humor and eagerness to get the most out of life.\n"
                },

                new Dog()
                {
                    Name = "Black and tan coonhound",
                    GroupName = "Hound Dogs",
                    Height = "23-27 inches",
                    Weight = "65-110 pounds",
                    LifeSpan = "10-12 years",
                    CoverImage = "BlackandTanCoonhound.jpg",
                    Info = "One of America's canine aristocrats, the Black and Tan Coonhound's bloodlines hark back to the Talbot hound of a thousand years ago, yet he's completely a creation of the mountain people of the Ozarks and the Smokies. \n"
                    + "\nNose to the ground, he singlemindedly trails his prey, primarily the raccoon but also mountain lions, bears, deer, and other game, 'barking up' when his quarry is treed. Of the six coonhound breeds, the Black and Tan is the one most frequently recognized, notable for his size and distinctive coloring. Among hunters, he's famous for his cold nose; that is, the ability to pick up and follow an old trail, no matter how faint. \n"
                    + "\nBecause of his strong hunting instinct and specialized skills, the Black and Tan Coonhound is rarely thought of as a family dog. Still, for people who admire the hound's independent nature and sense of humor, he can make an excellent companion and at home he tends to be laidback, playful, and gentle. \n"
                    + "\nThe stamina that makes this Hound a great hunting dog also makes him an excellent jogging or running companion. But he's equally satisfied with a good daily walk, especially if there's plenty of sniffing time built in. Afterward, expect him to sack out on the sofa, preferably in or near your lap. This is a dog who likes his comforts. \n"
                    + "\nBlack and Tan Coonhounds are fond of children and willing playmates. They get along well with other dogs and can even be buddies with cats if properly introduced. They possess good watchdog skills, and are likely to sound off with a deep-throated bark to alert you that someone's approaching. This dog is big enough to look intimidating, but unlikely to bite or otherwise harm anyone. \n"
                    + "\nAs with every breed, Coonhounds have some drawbacks. For one thing, they can have a houndy odor. This is something you'll either love or hate. Be sure you love it, because it can't be washed away for more than a day or two. \n"
                    + "\nAlso, these dogs can sing. No, you're not getting the Mormon Tabernacle Choir here but the deep bay of a hound who's treed a squirrel, cat, or other furry animal foolish enough to enter your yard. Lots of people love the music of the hounds, but those people might not include your neighbors. \n"
                    + "\nNor is this a breed for the houseproud. Black and Tan Coonhounds drool when it's hot, slobber after drinking water, and shed heavily. \n"
                    + "\nFinally, he's not for the faint of heart. A Coonhound needs a leader who's as stubborn and smart as he is.\n "
                    + "\nStill, if you can have a sense of humor and can accept his drawbacks, plus provide the Black and Tan with the human companionship he loves, moderate daily exercise, and firm, consistent, patient training, it's hard not to fall in love with this breed.\n "
                },

                new Dog()
                {
                    Name = "Blenheim spaniel",
                    GroupName = "Companion Dogs",
                    Height = "12-13 inches",
                    Weight = "13-18 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "BlenheimSpaniel.jpg",
                    Info ="The Cavalier King Charles Spaniel is a beautiful small dog that undoubtedly is a contender for the title of 'top tail-wagger.' In fact, among the characteristics that Cavalier breeders strive to attain is a tail in constant motion when this breed is moving.\n\n"
                    + "If the characteristic wagging of the Cavalier's plumy tail doesn't melt your heart, surely his large, dark round eyes will. Warm and lustrous, with a sweet expression, they hold the power to extract constant petting and unlimited supplies of food from people under their spell. Not surprisingly, this breed can easily become fat, which spoils its lovely lines, so be strong and offer a walk or playtime instead of the potato chips and pizza your Cavalier is angling for.\n\n"
                    + "Cavaliers pad through the house on slippered paws, always following in the footsteps of their people. With a Cavalier in residence, you'll never be alone — not even in the bathroom. Because they're so attached to their people, they do best when someone is at home during the day to keep them company. They are a housedog and will never thrive in an environment where they're relegated to the backyard or otherwise ignored.\n\n"
                    + "When it comes to training, Cavaliers are generally intelligent and willing to try whatever it is you'd like them to do. Food rewards and positive reinforcement help ensure that training goes smoothly. Cavaliers have a soft personality, so yelling at them is counterproductive and likely to send these sweeties into the sulks or into hiding. Instead, reward them every time you see them doing something you like, whether it's chewing on a toy instead of your Prada pumps or not barking in response when the dog next door barks. They'll fall all over themselves to find more things that you like.\n\n"
                    + "As with many toy breeds, Cavaliers can have issues with housetraining, but if you keep them on a consistent schedule, with plenty of opportunities to potty outdoors, they can become trustworthy in the home.\n\n"
                },

                new Dog()
                {
                    Name = "Bloodhound",
                    GroupName = "Hound Dogs",
                    Height = "23-27 inches",
                    Weight = "80-110 pounds",
                    LifeSpan = "10-12 years",
                    CoverImage = "Bloodhound.jpg",
                    Info = "When we think of the Bloodhound, the images that come to mind range from the baying mantrailers in such films as Cool Hand Luke to a lazy hound sunning himself on the front porch of a home in a sleepy Southern town.\n\n"
                    + "The mantrailer is the more accurate image, but it also presents a somewhat false picture of the breed. The Bloodhound is indeed single-minded on the trail, but what many people don't realize is that once he's found his quarry, he might lick the person to death, but he'll never attack.\n\n"
                    + "This wrinkled hound is gentle and affectionate, but he's far from lazy. He can follow a scent trail for miles and will always prefer that to sleeping on the sun porch. Expect to commit to long walks every day if you live with a Bloodhound.\n\n"
                    + "The Bloodhound belongs to a group of dogs that hunt together by scent, known as Sagaces, from the Latin, which is the same root as the word 'sagacious' referring to the qualities of keen discernment and sound judgment. Those words are certainly descriptive of the Bloodhound's powers of scent.\n\n"
                    + "Originally used in medieval Europe to trail boar and deer, modern-day Bloodhounds have found careers as mantrailers for police departments and search and rescue organizations. So skillful are they that their 'testimony' is considered admissible in a court of law. He can be a family dog, too, but he requires a high level of care.\n\n"
                    + "It's not everyone who can live with a large dog who slings slobber, exudes a distinctive houndy odor, wants nothing more than to follow his nose, wreaks destruction in puppyhood, has endless energy and endurance, and is the definition of the word stubborn. If you can, you'll find the Bloodhound to be kind, sensitive, and tolerant of children and other animals. With the right family, he's a dog of great character who brings much joy and laughter.\n\n"
                },

                new Dog()
                {
                    Name = "Bluetick",
                    GroupName = "Hound Dogs",
                    Height = "21-27 inches",
                    Weight = "45-80 pounds",
                    LifeSpan = "11-12 years",
                    CoverImage = "Bluetick.jpg",
                    Info = "These dogs have a noble history, being descendants of the French Grand Bleu de Gascogne and the English Foxhound, many of whom were brought to the United States in colonial times. On the trail, the Bluetick may be slower than some of his coonhound compatriots, but he has a superior nose and a never-say-die attitude.\n\n"
                    + "Although he's a hunter first and foremost, the Bluetick can be a fine housedog and loves his people. Bear in mind that hounds are a challenge to train. Be patient and persistent as you help them find their motivation, which is more likely to be food than any real desire to please.\n\n"
                    + "Males stand 24 to 30 inches at the shoulder and weigh 55 to 100 pounds. Females are 23 to 28 inches and weigh 45 to 85 pounds.\n\n"
                    + "The smooth, glossy coat is dark blue, thickly mottled with black spots on the back, ears, and sides. The head and ears are mostly black, with tan markings over the eyes and on the cheeks. The Bluetick Coonhound has dark red ticking on the feet, the lower legs below the body line, the chest, and below the tail.\n\n"
                },

                new Dog()
                {
                    Name = "Border terrier",
                    GroupName = "Terrier Dogs",
                    Height = "12-15 inches",
                    Weight = "11-15 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "BorderTerrier.jpg",
                    Info = "The Border Terrier is a small dog with an alert gaze, a powerful drive to hunt and dig, the typical high terrier energy level, and a good-natured personality. He's intelligent, loyal, fearless, loving, and determined, and about as aggravating as any dog can be.\n\n"
                    + "After that intro, you may be quickly hitting the back button to hunt for a different breed — and that may be exactly what you should do. The Border Terrier is not for everyone, and before taking one home, you should be fully committed to taking his antics in stride with an amused shake of your head.\n\n"
                    + "But for the right people, Border Terriers are wonderful dogs who play hard and love harder. They're ideally suited to active families who can give them plenty of exercise and prevent them from practicing their escape-artist skills.\n\n"
                    + "Border Terriers need a securely fenced yard to keep them safe. Given a lack of supervision and enough time alone, they'll dig under or climb over fences to go exploring. They'll escape through holes in fences, through open gates and doors, or by any other means they can find. In fact, they're bred to be able to cross any wall or scramble through any wire entanglement.\n\n"
                    + "The drive to chase prey is another inherent part of a Border Terrier's personality. He'll run right in front of a car in pursuit of a cat or rabbit. A Border Terrier's more likely to die in an accident than of old age, so be prepared to protect him from himself.\n\n"
                    + "It's also important to prevent boredom. A bored Border — one who's left alone for long periods — becomes noisy and destructive. This is not a dog that does well left out in the yard all day. You'll likely come home to find your neighbors lined up to complain about the barking (which is meant to be heard from 10 feet underground) and your yard filled with holes indicating that your Border is well on his way to China.\n\n"
                    + "To keep your Border and the neighbors happy and your yard free of holes, give your Border at least half an hour per day of vigorous exercise. Besides keeping him entertained, exercise will help keep your Border trim — this small breed is prone to obesity.\n\n"
                    + "With their needs for companionship and activity met, Borders are happy dogs who generally get along well with everyone from children to strangers. They'll bark at noises, making them excellent watchdogs, but don't expect them to be fierce guard dogs if an intruder enters your home.\n\n"
                    + "The Border Terrier can make you laugh and cry and laugh some more. He approaches training with an independent spirit, but he wants to please. If you praise him for a job done well, he'll quickly learn anything you can teach. He can be a handful, but he's always the apple of his owner's eye.\n\n"
                },

                new Dog()
                {
                    Name = "Borzoi",
                    GroupName = "Hound Dogs",
                    Height = "26 inches & up",
                    Weight = "60-100 pounds",
                    LifeSpan = "9-14 years",
                    CoverImage = "Borzoi.jpg",
                    Info = "With his tall, lean body, long, narrow head, and silky coat, the Borzoi is the picture of refinement and elegance. Borzois carry themselves proudly, and it's easy to envision them lounging in the palaces of Russian Tsars or swiftly running down a wolf in the Russian countryside. But before you bring a Borzoi to your palace, you need to decide if a Borzoi is right for you.\n\n"
                    + "Prized for their grace as well as their sweet dispositions, Borzoi are known for their speed, juxtaposed with a laidback personality. They prefer a quick sprint to long-distance running and are then satisfied to return indoors to relax on a favorite sofa. They're not what you'd call a high-energy dog. If you want to spend the day in bed or on the sofa, your Borzoi will be happy to spend it there with you.\n\n"
                    + "Despite his relaxed attitude and regal appearance, the Borzoi is not simply a beautiful showpiece for your home. This giant breed, whose height ranges from 28 to 32 inches, has a mind of his own and a desire for human companionship. He's not the best choice for people who are away from home for long hours every day. His luxurious double coat, which kept him warm during brutal Russian winters, sheds heavily. His size is also a consideration for people with small children. The Borzoi is gentle, but puppies are enthusiastic and may accidentally knock over a toddler in play.\n\n"
                    + "The Borzoi's athleticism serves him well in dog sports. Naturally, he's beautiful in the show ring, and he can also compete well in agility, obedience, and rally. But where he shines is in the lure coursing field, exercising his natural instinct to chase. In Western states, Borzoi are sometimes used in open field coursing to hunt jackrabbit, and some farmers use them against coyotes to protect their livestock.\n\n"
                    + "No longer a royal hunting companion, today the Borzoi's most important job is that of family friend. With his sweet, gentle demeanor, it's a job at which he excels.\n\n"
                },

                new Dog()
                {
                    Name = "Boston terrier",
                    GroupName = "Companion Dogs",
                    Height = "15-17 inches",
                    Weight = "12-25 pounds",
                    LifeSpan = "11-13 years",
                    CoverImage = "BostonTerrier.jpg",
                    Info = "The Boston Terrier may have been bred to be a ferocious pit-fighter, but you'd never know it today. The little American Gentleman, as he was called in the 19th century, is definitely a lover, not a fighter, although males have been known to show their terrier ancestry with a bit of posturing when they feel their territory is being invaded by another dog.\n\n"
                    + "Boston Terriers are known for being very intelligent — sometimes too much so. Their lively, affectionate nature makes them extremely loveable, though their sometimes stubborn nature or spurts of hyperactivity can land them in hot water with their owners. Any angst about their behavior, however, soon melts when they look up at you with those huge, round eyes that seem to say 'I love you.'\n\n"
                    + "Although Boston Terriers are small, they're sturdy and muscular. They have a sleek, shiny, straight coat with crisp white markings in a pattern that resembles a tuxedo — part of the reason they gained the name American Gentleman. Boston Terriers' distinctive ears naturally stand erect and are quite large. And then there's those big, beautiful eyes that are set quite apart to add to their outstanding good looks.\n\n"
                    + "Boston Terriers have a broad, flat-nosed face without wrinkles. They belong to a class of dogs called brachycephalic (brachy meaning short, and cephalic meaning head). Like other brachycephalic dogs, the lower jaw is in proportion to the body, but they have a short upper jaw to give them a 'pushed in' face.\n\n"
                    + "Boston Terriers' carriage give them a presence that goes beyond their size. They have a slightly arched, proud neckline, a broad chest, and a sturdy, boxy appearance. Their tail is naturally short (docking is forbidden) and set low on the rump.\n\n"
                    + "The Boston Terrier's small size and lively, affectionate nature make him a great family pet and companion. They love children and amuse people of all ages with their antics and unique, appealing expression. They are especially good companions for older people and apartment dwellers. Although gentle and even-tempered, they can have the spunky attitude of their terrier ancestors.\n\n"
                },

                new Dog()
                {
                    Name = "Chihuahua",
                    GroupName = "Companion Dogs",
                    Height = "5-8 inches",
                    Weight = "not exceeding 6 pounds",
                    LifeSpan = "14-16 years",
                    CoverImage = "Chihuahua.jpg",
                    Info = "The Chihuahua is a saucy little hot tamale and not just because of his association with a certain fast-food Mexican restaurant. He's renowned for being the world's smallest dog, but he may well have the world's biggest personality stashed inside that tiny body. That larger-than-life persona makes him appealing to men and women alike.\n\n"
                    + "Fun loving and busy, Chihuahuas like nothing better than to be close to their people. They follow them everywhere in the house and ride along in tote bags when their people run errands or go shopping. It's not unusual for Chihuahuas to form a close bond with a single person, and they can become very demanding if they're overindulged.\n\n"
                    + "Besides being affectionate housemates, Chihuahuas are intelligent and fast learners. They can compete in agility and obedience trials with just as much enthusiasm and success as larger dogs. That said, they're willful little dogs. You'll be most successful if you can persuade them that competing — or simply doing as you ask — is fun. Use positive reinforcement in the form of praise and food rewards when training your Chihuahua. He won't respond to harsh treatment.\n\n"
                    + "It's important when considering the Chihuahua to take into account his small size. Chihuahuas are curious and bold explorers. They've escaped from yards through small gaps in the fence and can squeeze into places that other puppies and dogs wouldn't be able to fit. And even though they tend to rule the roost, they can be accidentally injured by rambunctious larger dogs.\n\n"
                    + "Chihuahuas are not recommended for homes with children under the age of eight, simply because of the chance of injury by a young child. Regardless of your family situation, it's important to remember to socialize your Chihuahua to children, adults, and other animals. Chihuahuas are mistrustful of strangers, which makes them good watchdogs, but they need to learn to meet people in a friendly manner. It's also important to remember that Chihuahuas tend to forget they are small and will stand up to a larger aggressive dog; as a result the Chihuahua needs vigilant supervision in new situations, while they're on walks, and when they're in the yard.\n\n"
                    + "The Chihuahua's personality and unique size make him a wonderful go-everywhere companion. People who live with Chihuahuas become devoted to them, and many say that once you share your life with one, there will be no other dog breed for you.\n\n"
                },

                new Dog()
                {
                    Name = "Dandie dinmont terrier",
                    GroupName = "Terrier Dogs",
                    Height = "8-11 inches",
                    Weight = "18-24 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "DandieDinmontTerrier.jpg",
                    Info = "The Dandie Dinmont Terrier is a small dog with a unique appearance and the distinction of being the only dog named after a fictional character. This low-to-the-ground dog, with a body that is longer than he is tall and a distinctive 'poof' of hair on his head, had been bred for many years before he gained fame and a name in Sir Walter Scott's book Guy Mannering, published in 1814.\n\n"
                    + "In that book, a farmer is portrayed as having six small, long terriers — three with a salt-and-pepper coloring and three with a 'mustard' tone to their coats. The farmer's name was Dandie Dinmont and so the little dogs came to be known as Dandie Dinmont's terriers, with the apostrophe 's' being dropped as time went by.\n\n"
                    + "Even the color designations of the breed came from this fictional farmer. He had only two names for his small dogs: Pepper and Mustard. He differentiated them by calling them Auld Pepper, Auld Mustard, Young Pepper, Young Mustard, Little Pepper and Little Mustard. To this day the two colors of the breed are still known as Pepper (bluish black) and Mustard (shades of golden brown).\n\n"
                    + "In his book, Scott, who owned some Dandies of his own, described the little dogs as follows: 'He evolved from the Scottish Hillside, the grey mists forming his body, a bunch of lichen his topknot, crooked juniper stems his forelegs and a wet bramble his nose.'\n\n"
                    + "Dandie Dinmonts are unusual looking dogs that unfortunately are becoming rare. They have large, domed heads, with large, dark eyes that are set low in the front of the head. Their long ears are set low on the skull and fringed at their tips. Dandies have large chests and long backs.\n\n"
                    + "Unlike most terriers, Dandies have many curves in their shape. The back arches over the loin (the back end) and drops slightly to the base of the tail, which itself curves like a scimitar. Their front legs are short and powerful with paws that turn slightly outward for digging. The hind legs are slightly longer than the front legs, and not as heavy. They typically are 8 to 11 inches tall and weigh 18 to 24 pounds.\n\n"
                    + "Dandies are affectionate, lively dogs. Like many terriers, they also are independent and determined. They are very intelligent and typically are bold in defending their territory and family, but reserved with strangers, at least initially. Many describe them as being dignified, and even 100 years ago, they were described as having 'melancholy eyes as of a nobleman in disguise.'\n\n"
                    + "Dandies typically get along well with children and other pets, so long as they are brought up with them or exposed to them in puppyhood.\n\n"
                    + "Although their exercise needs are not great, you should always keep them on a leash in unfenced areas, as their instincts to chase game might kick in at an unexpected moment.\n\n"
                    + "Training your Dandie will take a bit of patience. They seem to get bored with repetitive tasks. Make training fun for your Dandie, and you'll be amazed at how quickly he learns and how clever he truly is.\n\n"
                },

                new Dog()
                {
                    Name = "English foxhound",
                    GroupName = "Hound Dogs",
                    Height = "24 inches",
                    Weight = "60-75 pounds",
                    LifeSpan = "10-13 years",
                    CoverImage = "EnglishFoxhound.jpg",
                    Info = "Although most of us have never seen one in person, movies, books, and cartoons have familiarized us with the image of a pack of English Foxhounds in hot pursuit of a red fox.\n\n"
                    + "Wearing the familiar tricolor coat of black, white and tan, they have hanging ears that lie close to their cheeks, and a long tail — known as the stern and carried up — that tapers to a point. A description of Belvoir Gambler, recognized as the greatest English Foxhound ever bred, says, 'Next to an old Greek statue, there are few such combinations of grace and strength as a fine Foxhound.'\n\n"
                    + "This rare breed has never made the leap to popular companion dog, but he is certainly a dog to consider if you're a jogger or runner or would like a canine friend to accompany you on horseback rides. This intelligent, courageous hound can cover long distances without a break. Foxhunters prize him for his stamina, good nose, and determination.\n\n"
                    + "Those characteristics have pros and cons for people who are interested in him as a companion. For example, his stamina and determination make him a good pal for marathon runners, but his powerful scenting ability can make him desirous of following an interesting trail rather than going where you want.\n\n"
                    + "He needs daily exercise, so he's not a good choice for the weekend warrior. And being a hound, whose job it is to go after prey, he must be kept on leash in areas where he could run in front of a car. On the up side, he's gentle, social, and tolerant, making him a good family dog for people with an active lifestyle who have plenty of time to devote to keeping him busy.\n\n"
                    + "Because of his high energy level, he's not really suited to apartment life. He needs a daily exercise partner and a large fenced yard or, better yet, an acreage where he can run.\n\n"
                    + "English Foxhounds are working dogs. If you are looking for an English Foxhound as simply a companion, seek out one that has been bred for the show ring rather than for hunting. He'll have a little less energy and drive than a field dog.\n\n"
                },

                new Dog()
                {
                    Name = "Entle bucher",
                    GroupName = "Companion Dogs",
                    Height = "16-21 inches",
                    Weight = "40-65 pounds",
                    LifeSpan = "11-13 years",
                    CoverImage = "EntleBucher.jpg",
                    Info = "The Entlebucher, or Entle for short, is a Swiss herding breed related to the Appenzeller, the Bernese Mountain Dog, and the Greater Swiss Mountain Dog; of the four, he's the smallest.\n\n"
                    + "He's known for his intelligence, personable attitutude, agility, and loyalty. He's independent and self-confident, yet he bonds strongly to his person and is happiest spending the day at his family's side. He's got energy to burn, and needs an owner who can give him about an hour of vigorous exercise a day — if not herding flocks, then competing in dog sports like tracking, frisbee, or agility. Like other smart working dogs, he loves having jobs to do, so begin training this smart cookie early, teaching him to gather up dirty laundry, bring in the newspaper, fetch your slippers, or other useful tasks.\n\n"
                    + "The Entlebucher can be territorial and will bark to announce the presence of strangers or arrival of guests. He's aloof with people he doesn't know, and like any dog, he needs early socialization to learn how to behave around strangers and other dogs. He loves his kids but, because he also loves roughousing, he must learn to be gentle with little ones. He may try to 'herd' his kids by nipping at their heels.\n\n"
                    + "Size\n"
                    + "Males are 17 to 21 inches at the shoulder; females are 16 to 20 inches. Weight ranges from 45 to 65 pounds.\n\n"
                    + "Coat Color And Grooming\n"
                    + "The Entle's coat is thick, dense, and tricolored. The coloring is mostly shiny black, with white on the chest, all four feet, and the tip of the tail, as well as a white blaze from the muzzle to the top of the head. Areas between the black and white are rust-colored. They have a thick undercoat and a top coat. Weekly brushing will help keep shedding to a minimum.\n\n"
                },

                new Dog()
                {
                    Name = "Golden retriever",
                    GroupName = "Sporting Dogs",
                    Height = "21-24 inches",
                    Weight = "55-75 pounds",
                    LifeSpan = "10-12 years",
                    CoverImage = "GoldenRetriever.jpg",
                    Info = "It's no surprise that the Golden Retriever is one of the top ten most popular dogs in the U.S. It's all good with the Golden: he's highly intelligent, sociable, beautiful, and loyal.\n\n"
                    + "He's also lively. The Golden is slow to mature and retains the silly, playful personality of a puppy until three to four years of age, which can be both delightful and annoying. Many keep their puppyish traits into old age.\n\n"
                    + "Originally bred for the physically demanding job of retrieving ducks and other fowl for hunters, the Golden needs daily exercise: a walk or jog, free time in the yard, a run at the beach or lake (Goldens love water), or a game of fetch. And like other intelligent breeds who were bred to work, they need to have a job to do, such as retrieving the paper, waking up family members, or competing in dog sports. A tired Golden is a well-behaved Golden.\n\n"
                    + "As well as giving your Golden Retriever physical and mental exercise, you should also be prepared to include him in your family activities. The Golden Retriever is a family dog, and he needs to be with his 'pack.' Don't consider getting a Golden unless you're willing to have him in the house with you, underfoot, every day.\n\n"
                    + "There's one other potential drawback to the breed: He's definitely not a watchdog. He might bark when strangers come around, but don't count on it. Most likely, he'll wag his tail and flash that characteristic Golden smile.\n\n"
                },

                new Dog()
                {
                    Name = "Groenendael",
                    GroupName = "Herding Dogs",
                    Height = "22-26 inches",
                    Weight = "45-75 pounds",
                    LifeSpan = "12-14 years",
                    CoverImage = "Groenendael.jpg",
                    Info = "The Belgian Sheepdog (known as the Groenendael in Europe) is the solid-colored variety of the four Belgian shepherd dogs. Elegant and graceful, he has a long black coat and an imposing appearance. He's athletic as well as beautiful and maintains the working ability for which he was originally known, making him an excellent choice for agility, herding, and obedience competitions.\n\n"
                    + "The Belgian Sheepdog combines the versatility of a working dog with the gentleness of a family companion. He makes a wonderful family companion as long as he receives the exercise he needs.\n\n"
                    + "Of all the traits this breed has, energy is at the top of the list of what to consider before you purchase. The Belgian Sheepdog is not a breed that enjoys lazing around the house; he's a working dog and needs a job to do. Herding dogs such as the Belgian Sheepdog are hard-wired to chase after a flock of sheep all day long. That instinct doesn't disappear just because they're living in a family home instead. Expect to give him at least an hour of exercise per day. The Belgian Sheepdog is very intelligent and needs variety to keep from becoming bored. He's not a good choice for people who work long hours and have no way of exercising their dog during the day. If he's left to his own devices, he's likely to create his own entertainment — generally something you won't like that will be expensive to repair — or to develop separation anxiety.\n\n"
                    + "They do better in homes with a fenced yard. Their herding heritage makes Belgian Sheepdogs chasers, and they'll take off after joggers, bicyclists, and cars if they aren't contained by a fence.\n\n"
                    + "Loving and loyal, the Belgian Sheepdog will always protect 'his' children, but it's important for parents to supervise play when neighboring children are around. The Belgian may mistake the noise and high spirits of play as an assault and try to nip at your child's friends. With proper supervision and corrections, you can teach him that this isn't appropriate behavior. Belgian Sheepdogs do best with children when they're raised with them from puppyhood or socialized to them at an early age.\n\n"
                    + "They can get along well with other dogs and cats if they're brought up with them, although they may have issues with strange animals that come onto their property. They love to chase — that herding instinct again! — so cats who stand their ground will probably fare better than those who turn tail and run.\n\n"
                    + "This versatile dog has many excellent characteristics, but he's probably not suited to a first-time dog owner. He's loving, loyal, and energetic, but can also be shy, sensitive, and strong-willed. When you put time and effort and energy into him, however, he's well worth all your work.\n\n"
                },

                new Dog()
                {
                    Name = "Ibizan hound",
                    GroupName = "Hound Dogs",
                    Height = "22-27 inches",
                    Weight = "45-50 pounds",
                    LifeSpan = "11-14 years",
                    CoverImage = "IbizanHound.jpg",
                    Info = "He comes from the trendy Spanish island of Ibiza, but the elegant Ibizan Hound is a canine classic whose history dates to the time of the pharaohs of Egypt. The beautiful red and white dog has a long, narrow head that resembles that of the Egyptian jackal god Anubis, large, erect ears that can point forward, sideways, or be folded backward, and flesh-colored pigment on the nose and eye rims, all of which combine to give him a unique appearance. More important is the wonderful personality that shines through.\n\n"
                    + "The Ibizan Hound, nicknamed Beezer by his fans, is playful and sometimes silly. He's not a touchy-feely dog, but he enjoys snuggling with members of his family. The Ibizan can be reserved with strangers and protective of his home, but he should never be shy or aggressive.\n\n"
                    + "A medium-size sighthound who was developed to hunt rabbits and other small game, he was bred for speed, stamina, and determination. Today, those talents make this athletic dog a match for some of the top coursing breeds, as well as an excellent competitor in agility, thanks to his ability to jump high and far.\n\n"
                    + "Ibizan Hounds enjoy their comforts — that sleek, sculpted body needs cushioning, after all — and can become couch potatoes who enjoy spending their days sleeping. Their exercise needs are moderate. They'll enjoy a couple of 20- or 30-minute walks or jogs daily. Whenever possible, give them a chance to run full out in a large, safely fenced area.\n\n"
                    + "Their ability to jump high from a standstill makes Ibizans notorious as counter surfers. Never trust them alone with food, no matter how out of the way you think it is. Outdoors, protect them with a secure fence that's at least six feet high. Ibizans cannot be trusted off-leash unless they are in a fenced yard. They have a strong prey drive and will chase anything that moves quickly. For this reason, they're not suited to families who have pets such as rabbits, although they get along fine with other dogs and can learn to live with cats if they're raised with them.\n\n"
                    + "The Ibizan Hound comes in two coat types, shorthaired and wirehaired, and both are easy to maintain.\n\n"
                    + "Regardless of whether you want to compete or simply want a wonderful companion, this could be the breed for you. An Ibizan will walk or run with you, love you, and always make you laugh.\n\n"
                },

                new Dog()
                {
                    Name = "Irish terrier",
                    GroupName = "Terrier Dogs",
                    Height = "18 inches",
                    Weight = "25-27 pounds",
                    LifeSpan = "13-15 years",
                    CoverImage = "IrishTerrier.jpg",
                    Info = "The Irish Terrier's motto is 'No fear.' Nicknamed 'Daredevil,'this medium-size, agile dog has a tight, wiry red coat and a snootful of courage. He's animated and loyal, always on guard, and willing to take on anything that comes his way and threatens his people and home.\n\n"
                    + "With that tough terrier attitude, however, comes a need for training and socialization from an early age. Irish Terriers are extremely intelligent and learn easily, but any training must work around their independent, willful spirit. If you can make the dog think that training is his idea, you'll get a happy worker who meets or exceeds any goals you may have set for him. That's balanced by a reckless spirit that can be blind to consequences, so it can be necessary to protect him from his sometimes intemperate desire to guard his loved ones.\n\n"
                    + "Irish Terriers are wonderful watchdogs, barking to warn their owners of anything new. Some dogs will become excessive barkers if their behavior isn't controlled from the start. Thanking the dog for the alert and then distracting him with another command or game is a good way to make sure your dog learns to control his barking.\n\n"
                    + "Irish Terriers are excellent people dogs when they receive early socialization, and this helps make them wonderful family companions. They're best suited to families where someone is home during the day. They aren't overly active indoors and are happy to relax with their people, but they need exercise in the form of walks and occasional romps in a securely fenced area. The Irish Terrier has excellent hunting skills and a strong desire to seek out and destroy vermin, so a fenced yard and leashed walks are necessary for his safety. He'll chase rapidly moving objects without paying attention to where the chase is leading him.\n\n"
                    + "Irish Terriers adore children and are great playmates, especially when raised with them. Make sure very young children are supervised at all times to prevent injury to both the dog and the child.\n\n"
                    + "Irish Terriers can learn to get along with cats if they're raised with them from puppyhood, but they may not be trustworthy around smaller pets, especially pets from the rodent family such as mice, rats, hamsters, and gerbils. Their terrier instinct to hunt this type of animal may be too strong to overcome.\n\n"
                    + "This breed does not do well with other dogs. Irish Terriers can be aggressive toward dogs of the same sex, and they don't back down from a challenge. They will fight to the point of serious injury to themselves or the other dog. Being fearless, they'll take on dogs much larger than themselves without thought for the consequences. Make sure your dog is on leash and you have control when around other dogs at any time.\n\n"
                    + "With his speed, endurance, and grace the Irish Terrier is an excellent competitor who loves the challenge of the agility ring. He can do well in the sports of obedience and rally, and his soft mouth and love of water make him a capable hunting dog who can retrieve game birds on land or from water. Irish Terriers are also excellent show dogs.\n\n"
                    + "If you're looking for a versatile, active, spunky dog who will watch over your family for many years, the Irish Terrier could be the breed for you. He's not one of the more well-known breeds, so finding a breeder with puppies can be difficult. Expect to spend some time on a waiting list and to pay a higher price than you might for a more popular breed. The expense is well worth it, though, admirers say. If you find the right dog, the Irish Terrier can be the most wonderful companion your family will ever have.\n\n"
                },

                new Dog()
                {
                    Name = "Irish wolfhound",
                    GroupName = "Hound Dogs",
                    Height = "30-32 inches",
                    Weight = "105-120 pounds",
                    LifeSpan = "6-8 years",
                    CoverImage = "IrishWolfhound.jpg",
                    Info = "When Irish eyes are smiling, you can be sure they belong to an Irish Wolfhound. He has a noble and commanding appearance, but beneath his shaggy eyebrows twinkle eyes with a sweet, gentle expression.\n\n"
                    + "This ancient breed originated in Ireland, where he served as both a war dog and hunting dog. He came close to extinction in the 19th century after the great prey animals — wolves, deer, and wild boars — had largely disappeared in Ireland, but the breed was revived and today is a wonderful companion who draws the admiration of many.\n\n"
                    + "The Irish Wolfhound is the tallest of all dog breeds and the largest of the sighthounds — dogs that chase moving prey. Despite his distant past as a ferocious war dog, he's a gentle giant who gets along with everyone, including children, other dogs, and sometimes even cats. He loves long walks, which are important in maintaining his huge body, but otherwise he's satisfied to be a couch potato.\n\n"
                    + "While they're quiet indoors, Irish Wolfhounds are not recommended for apartment living. Consider whether you'd be able to get one up and down the stairs if he were injured or sick. They do best in a home with a large fenced yard where they can have room to run.\n\n"
                    + "The Irish Wolfhound is not the ideal watchdog. He doesn't bark an alarm, and although he has the size to deter many would-be intruders he doesn't have the nature of a guard dog. He's brave but not aggressive.\n\n"
                    + "Like any dog, the Irish Wolfhound isn't the breed for everyone. His gigantic size alone is a consideration. He has several health issues that potential owners must be aware of. And he's a short-lived breed who has only a 6- to 8-year life span. If you're looking for a breed that lives many years and is easy to care for, then he's not the breed for you. But if you're looking for a companion who will fill your life with love, admiration, and sloppy kisses, then look no further.\n\n"
                },

                new Dog()
                {
                    Name = "Italian greyhound",
                    GroupName = "Companion Dogs",
                    Height = "13-15 inches",
                    Weight = "7-14 pounds",
                    LifeSpan = "14-15 years",
                    CoverImage = "ItalianGreyhound.jpg",
                    Info = "If you're an art lover, you may have seen the Italian Greyhound in centuries-old portraits, immortalized with their noble owners by famous artists. This slender, elegant dog is the smallest of the sighthounds — the group of dogs bred to hunt by sight and give chase — and closely resembles his much larger Greyhound cousin.\n\n"
                    + "Agile and athletic, he has a small, muscular body and an elegant high-stepping gait. The IG, as he's often called, retains his instinct for hunting small game and will chase anything that moves. He can reach top speeds of 25 miles per hour, so if he gets loose he won't be easy to catch. Although he's small, he has lots of energy and appreciates plenty of opportunities to exercise. A fit IG can even make a good jogging partner.\n\n"
                    + "The Italian Greyhound has a gentle personality, loving and affectionate with family members, but often reserved or shy with strangers. Despite his mild nature, he has a surprisingly deep, big-dog bark, making him a good watchdog — although he's too small to back up his barks and provide any actual protection.\n\n"
                    + "This is an intelligent breed who can be easy to train, but you'll need to make it fun for him to overcome his 'what's in it for me?' attitude. When well trained, he can shine in dog sports such as obedience training, agility, and rally. The athletic, graceful IG seems built for agility, and many love the sport and do it well.\n\n"
                    + "What they don't do well is housetraining. Like many small breeds, the IG can be difficult to housetrain, and some dogs are never completely trustworthy in the house.\n\n"
                    + "Aside from the occasional cleanup, life with an IG is both restful and zestful. He loves snuggling with his people for a while, then flying around the house and jumping on furniture and tabletops. IGs are catlike in their love of high places, and you'll often find them perched on the backs of chairs, on windowsills, or any other high spot they can reach. Older IGs are more sedate and will cuddle with you on your recliner and just enjoy the day.\n\n"
                    + "On sunny days, expect to find your IG sunbathing in the yard, one of his favorite pastimes. He loves warmth and is fussy about getting cold or wet. It's not unusual for IG owners to have a sheltered area in the yard so their dogs can go potty on rainy days without getting their feet wet. At night, he'll burrow beneath the covers on your bed.\n\n"
                    + "Your IG will demand attention if he feels he's being ignored. Privacy becomes a distant memory once you own an Italian Greyhound, because he'll follow you everywhere at all times. He's also curious and will investigate anything that catches his interest.\n\n"
                    + "The Italian Greyhound is one of those small dogs with a big personality. He's affectionate, possessive, and loving, charming his way into your life. If you can give him the attention, exercise, and training he needs — not to mention tons of love — then the Italian Greyhound can make an elegant and loveable addition to your household.\n\n"
                },

                new Dog()
                {
                    Name = "Japanese spaniel",
                    GroupName = "Companion Dogs",
                    Height = "8-11 inches",
                    Weight = "7-11 pounds",
                    LifeSpan = "10-12 years",
                    CoverImage = "JapaneseSpaniel.jpg",
                    Info = "Jumpin' jiminy! Is that a Japanese Chin on your fireplace mantel? It is! People who live with the Chin often marvel at the breed's ability to leap tall furniture in a single bound. The toy-size Japanese Chin has a catlike nature that includes the desire to be in high places, the ability to climb, and the tendency to wash himself. He has also been seen batting at objects much like a cat would.\n\n"
                    + "Feline traits notwithstanding, the Japanese Chin has all of the qualities one looks for in a companion dog. He thrives when he's with his people, and he loves everyone. Japanese Chin do well in apartments and will adapt to any living situation, but their tiny size and love of human companionship mean they're not suited to living outdoors or in a kennel.\n\n"
                    + "Japanese Chin have the classic look of an Oriental breed with a large, broad head; large, wide-set eyes; and a flattish face. Small, V-shaped ears hang down, set just below the top of the head. They carry their plumed tail jauntily over their back.\n\n"
                    + "They have an abundant coat, but looks are deceiving. The Chin is a wash-and-go breed and needs little more than a weekly brushing to maintain his elegant appearance. With the occasional exception of the ear fringes, the coat rarely mats, and it doesn't require any trimming.\n\n"
                    + "Intelligent and well mannered, the Japanese Chin learns quickly, but he has a mind of his own. If training becomes repetitive, he will choose to do something more entertaining. He can be difficult to housetrain, but if you're persistent and consistent he'll get the message.\n\n"
                    + "In general, the Japanese Chin is a happy dog who gets along with everyone. He's friendly toward other dogs and cats and is a playful companion for older children. Because of his small size, however, he's not suited to homes with young children, who might accidentally injure him. Chin are loving and devoted to their family, but they have a natural shyness around new people and new situations. It's not unusual for them to be slightly aloof with strangers until they get to know them.\n\n"
                    + "The Japanese Chin requires little in the way of exercise and is a great companion to people who can't get around easily. He enjoys a daily walk or play session but won't become destructive if you just lie around eating bonbons and playing with him. Chin enjoy playing, and they move with such grace and agility that they rarely disturb anything when they race through a home.\n\n"
                    + "These are sensitive dogs. They pick up on the emotions of the home and their owners and will shape their personality to match. If he lives in a home that is quiet and somber, the Japanese Chin will become quiet and reserved, yet still possess all the wonderful traits of a companion dog. If he lives in an active home, he will generally be lively and outgoing.\n\n"
                    + "Fun-loving and charming, the Chin can be addictive. People who love him can't imagine life without him, and many can't imagine life without two or three.\n\n"
                },

                new Dog()
                {
                    Name = "Keeshond",
                    GroupName = "Companion Dogs",
                    Height = "17-18 inches",
                    Weight = "35-45 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "Keeshond.jpg",
                    Info = "The Keeshond (pronounced KAYZ-hawnd) is a medium-sized dog with an impressive gray, black, and cream coat and a massive, plumed tail. He was known for years as the 'Dutch Barge Dog' because of his role as companion and guardian on barges and small boats on Holland's many canals and rivers.\n\n"
                    + "While the Keeshond will issue a stern bark when someone approaches his property, he's such a love that he'll readily accept anyone his owner brings into the household. In truth, he isn't a very effective guard dog.\n\n"
                    + "The Keeshond is a fan of cool weather. He likes spending time outside when the weather is crisp. However, he isn't a backyard dog; he's too people-oriented for that. He needs to live inside with his family and participate in all their activities.\n\n"
                    + "The Keeshond loves children and plays nicely with them (although, of course, adults should always supervise interactions between kids and any dog). The Keeshond also gets along well other dogs and pets if he is introduced to them at a young age.\n\n"
                    + "Besides being an excellent family pet, today's Keeshond can strut his stuff in the conformation ring, obedience ring, and rally competition. He's also sure-footed, which makes him a great agility competitor.\n\n"
                },

                new Dog()
                {
                    Name = "Maltese dog",
                    GroupName = "Companion Dogs",
                    Height = "7-9 inches",
                    Weight = "under 7 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "MalteseDog.jpg",
                    Info = "Throughout his long history, the Maltese has been given many names, such as the 'Melitae Dog,' 'Ye Ancient Dogge of Malta,' the 'Roman Ladies Dog,' 'The Comforter,' the 'Spaniel Gentle,' the 'Bichon,' the 'Maltese Lion Dog,' and the 'Maltese Terrier.' Today, he is known simply as the Maltese.\n\n"
                    + "This elegant toy dog breed is famed for the silky white hair covering his body. Straight and thick, the coat falls all the way to the floor. Many years ago, Maltese came in many colors, but these days they are always white. When a properly built Maltese moves, he seems to float beneath his cloud of white hair. Because he doesn't have an undercoat, the Maltese sheds little, and many people consider the breed to be hypoallergenic.\n\n"
                    + "But the Maltese is more than his coat. Completing the picture is a slightly rounded skull, black nose, drop ears, dark, alert eyes, short, straight legs, and a graceful tail. He's a sweet, intelligent dog who is devoted to his people. And as one of the smallest of the toy breeds, he's well suited to apartment or condo living. Wherever he lives, the Maltese is responsive to his environment and makes an effective watchdog.\n\n"
                    + "Although they look delicate and aristocratic, Maltese can have a lot of energy. They learn quickly if rewarded for their efforts. Because they have a long history as companion dogs, Maltese require a lot of human attention and suffer from separation anxiety. If left alone for hours each day, they can bark and become destructive.\n\n"
                    + "No breed is perfect, and Maltese sometimes are intolerant of small children or other dogs, especially if they have been overly pampered by their people. If this occurs, they can become very protective, barking and even biting if animals or people are perceived as a threat to their relationship with their beloved human family.\n\n"
                    + "Even tolerant Maltese are not a good choice for families with small children, however, because they are so small and can be easily injured. Like all dogs, they must be taught their place in your home, and require proper socialization and basic obedience training.\n\n"
                },

                new Dog()
                {
                    Name = "Norfolk terrier",
                    GroupName = "Terrier Dogs",
                    Height = "9-10 inches",
                    Weight = "11-12 pounds",
                    LifeSpan = "12-16 years",
                    CoverImage = "NorfolkTerrier.jpg",
                    Info = "If you're seeking a lively canine companion who is fearless, yet affectionate, the Norfolk Terrier may be the breed for you.\n\n"
                    + "With a perky, outgoing personality, and tireless constitution, the 12-pound Norfolk charms those who know and love him. Never boring, and certainly no couch potato, he is all terrier--tenacious, independent, hard-working, and charming.\n\n"
                    + "The Norfolk is also incredibly cute. With small, dark eyes sparkling with mischief, and a scruffy, wiry coat, it's difficult to resist his appeal.\n\n"
                    + "Norfolk Terriers have been known by different names over the years. They were called Cantab Terriers when Cambridge University students used to keep them as pets. They also have been called Trumpington Terriers, after a street in the area where the breed was developed. For a while, they were even called Jones Terriers, named after the man who first exported them to the United States.\n\n"
                    + "In 1932, the English Kennel Club called them Norwich Terriers because at the time, the Norwich and the Norfolk were considered the same breed. Norwich Terriers and Norfolk Terriers do look very much alike. The easiest way to tell them apart is by their ears: Norwich Terriers' are upright, and Norfolks' are folded.\n\n"
                    + "The Norfolk is relatively uncommon in the United States. Fewer than 300 puppies are born per year in America. Litters are small. So if you want a Norfolk, expect to wait up to one year.\n\n"
                    + "Even though the Norfolk is small, he is very strong. At 9 to 10 inches tall and weighing just 11 to 12 pounds, you might think this happy little canine is a lap dog who wants pampering. Far from it.\n\n"
                    + "While he is affectionate and loves his family, a Norfolk Terrier is always ready for the chase, whether it's vermin or fox. Because of his courage and ability to scrap with the best of foes, the Norfolk is allowed 'honor scars' in the show ring to attest to his field worthiness.\n\n"
                    + "Norfolk Terriers have steady, live-and-let-live personalities. They generally have a happy attitude and make a reliable companion for children if they've been raised with them. They're not known for being yappy, but they will bark when the need arises.\n\n"
                    + "If left alone outside for long periods of time or not given enough exercise, however, the Norfolk will amuse himself by barking and digging. Give your playful Norfolk a lot of toys and activities to occupy his mind, or he will find his own entertainment.\n\n"
                    + "As with all terriers, Norfolks should be kept on leash when in public areas because their strong hunting instinct is easily triggered by the sight of a squirrel, rabbit, or other small animal dashing by.\n\n"
                    + "If you choose a Norfolk, be prepared to have him as a part of your family for a very long time. These are hardy dogs that have been known to live into their late teens, still active and happily playing with their toys.\n\n"
                },

                new Dog()
                {
                    Name = "Norwegian elkhound",
                    GroupName = "Hound Dogs",
                    Height = "19-20 inches",
                    Weight = "48-55 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "NorwegianElkhound.jpg",
                    Info = "The Norwegian Elkhound was originally used to hunt moose and other big game. The name of this ancient breed is a complete misnomer; they weren't meant to hunt elk, and they aren't hounds. In Norwegian, Norsk Elghund means 'moose dog,' and in German, elch means 'moose' — probably part of the reason for the confusion in English.\n\n"
                    + "Linguistic history aside, the Elkhound has phenomenal stamina. While hunting, he would jump forward and back and around the moose, bear, or wolf, keeping it in one place and barking nonstop until the hunter arrived.\n\n"
                    + "While most people who live with a Norwegian Elkhound today don't hunt outside the refrigerator, think about his fearless and active noisemaking strategy before you choose to bring an Elkhound into your life. Norwegian Elkhounds are known for barking, and although the trait can be trained out of some, you can't bet on it.\n\n"
                    + "What this background means to the average dog owner is that exacting obedience work just isn't in the picture. He'll be fine in basic obedience and he makes a great family dog, but understand clearly that pleasing you is not the highest item on his to-do list. This is no Golden Retriever, so go get your own slippers. Toys are generally of no interest. He loves chasing balls, but you can forget about him bringing them back to you.\n\n"
                    + "That's what happens when you share your heart and home with an independent thinker. He'll want something in return for obedience work — which he sees as pointless — and you can forget a pat on the head as his reward. If you want to motivate your Elkhound in training and form a partnership, you'd better have a steady supply of treats on hand. Once an Elkhound bonds to you, though, you'll be an inseparable pair as far as he's concerned.\n\n"
                    + "Norwegian Elkhounds are strong-willed enough that they can take over a home if they're allowed half a chance. They love the dominant role, and without proper training and socialization, this can become a problem. Training can be difficult, and they need a firm and consistent owner.\n\n"
                    + "Naturally, they prefer a winter climate with lots of snow to play in. A true adventurer, the Elkhound wants his adventure to occur outdoors. Long daily exercise is a necessity, so if you're not ready to turn your couch potato ways into those of an outdoorsman, think twice — if you can't keep up, you'll soon be met with a house full of destroyed belongings that met their fates as he found ways to expend his endless energy. Not surprisingly, the Elkhound excels at fast-moving performance events such as agility.\n\n"
                    + "Once he's outside, the Elkhound may see game he just has to track, and he'll likely choose to ignore your calls for his return. Thanks to their strong prey drive, Elkhounds may even chase their quarry through plate-glass windows; and while they were bred to track but not attack game, they have been known to kill game on their own.\n\n"
                    + "That said, Norwegian Elkhounds are affectionate dogs who make devoted, wonderful family members. They're excellent with children and are terrific watch dogs, treating strangers with natural suspicion. They thrive on attention, and it's hard to find a more loyal companion.\n\n"
                },

                new Dog()
                {
                    Name = "Norwich terrier",
                    GroupName = "Terrier Dogs",
                    Height = "10 inches",
                    Weight = "12 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "NorwichTerrier.jpg",
                    Info = "The Norwich Terrier is one of the smallest of all the terriers, but what he lacks in size, he makes up for in personality and drive. This active terrier is a wonderful companion for an active individual or family. His name gives you a clue to his appearance and helps you tell him apart from his sibling, the Norfolk Terrier: remember that the Norwich has prick ears that stand up like a witch's hat.\n\n"
                    + "The Norwich Terrier was once used for hunting both vermin and foxes, and today he can still be seen hunting in a variety of places. Norwich Terriers are a working breed and are happiest when they have a job to do such as attending obedience class and practicing at home or participating in various dog sports. The Norwich successfully competes in obedience and agility trials, rally, and earthdog trials.\n\n"
                    + "You can see the drive of the Norwich Terrier in his day-to-day life: chasing squirrels and other rodents, bolting out doors and gates if unrestrained, and digging and barking for entertainment. These terrier habits can make him unsuited for the person or family who can't ensure these behaviors don't become a nuisance. On the plus side, he's loyal and alert, qualities that make him an excellent watchdog.\n\n"
                    + "Norwich Terriers are courageous, but they should never be aggressive. The breed is known for its loving and well-balanced nature and thrives on the companionship of the humans it loves.\n\n"
                    + "If you can cope with his high prey drive and tendencies to bark and dig, the Norwich Terrier is a wonderful companion and friend who may surprise you with his versatility and athleticism.\n\n"
                },

                new Dog()
                {
                    Name = "Otterhound",
                    GroupName = "Hound Dogs",
                    Height = "24-27 inches",
                    Weight = "80-115 pounds",
                    LifeSpan = "10-13 years",
                    CoverImage = "Otterhound.jpg",
                    Info = "Do you think life with a large, boisterous, shaggy dog would be perfect? If so, the Otterhound might be the dog for you.\n\n"
                    + "The Otterhound is an old breed, developed in England from Bloodhounds and other types of dogs. Although the Otterhound is believed to have been in existence for more than 500 years, it's a fairly rare breed today. There are currently fewer than 1,000 Otterhounds, only 350 to 500 of them residing in the United States. In fact, just four to seven litters are born each year in the United States and Canada. If you have your heart set on an Otterhound, expect difficulty finding one.\n\n"
                    + "Why is the breed so uncommon? No one knows for sure, but it certainly isn't because of the Otterhound personality. Sometimes called the 'class clown,' the Otterhound has a sweet, affectionate, fun-loving personality. He's independent, too, not demanding a lot of attention. After greeting you with enthusiasm, the Otterhound is likely to finish the nap he was taking when you arrived.\n\n"
                    + "The Otterhound is a large breed. Even small females weigh about 65 pounds, and large males can weigh 125 pounds. They're definitely dogs who take up space in the household.\n\n"
                    + "Otterhounds are great with kids, but because of their large size and bouncy personality, they may be too rowdy for very young or small children. They can also be too boisterous for frail seniors.\n\n"
                    + "The Otterhound has a distinctively shaggy look. His head appears to be very large and long; and his ears are long and folded, giving them a draped appearance. He's physically strong, with a long, striding gait. He has the extremely sensitive nose of a hound, and it's likely to lead him off to investigate his surroundings.\n\n"
                    + "Because the Otterhound was bred to hunt on land and in water, he has a rough, double coat and large, webbed feet. He comes in many different colors, the most common being a variation of black and tan grizzle, which often gets lighter as the dog gets older.\n\n"
                    + "The Otterhound has the distinctive and almost musical bark of the hound. This deep, loud, extended bay is music to a hunter's ears, but it might not play as well with the neighbors. Although some Otterhounds are quiet, most seem to like the sound of their own voices, so it's wise to teach your Otterhound a 'quiet' command.\n\n"
                    + "Speaking of voices, the Otterhound also has wide range of vocalizations, from grunts to groans. Some even like to 'sing' and vocalize with other dogs or with people.\n\n"
                    + "Otterhounds are usually good with other dogs and animals if they are raised with them or introduced carefully. The Otterhound benefits from a lot of socialization, especially as a pup, and it's good for him to be included in all aspects of your life.\n\n"
                    + "Otterhounds tend to be opinionated, so training requires patience, especially since they become especially playful when they don't want to comply with whatever you're asking them to do. And because of their large size, training is absolutely necessary.\n\n"
                    + "Despite size and strength, however, the Otterhound has a 'soft' personality; he doesn't respond to harsh training methods. It's best to be even more stubborn than he is, while keeping the training sessions short, fun, and positive for both of you.\n\n"
                    + "The Otterhound enjoys food, so this can be a great motivator in training. Be aware that his love of food can lead him astray: there are stories of Otterhounds who have learned to escape from any confinement to get into the kitchen, where they open cabinets, drawers, and even the refrigerator in order to steal a tasty tidbit.\n\n"
                    + "The Otterhound needs exercise, and a lot of it. He has a great deal of stamina and energy; jogging for three or four miles is like a walk in the park to him. If left alone in the backyard for long periods of time, especially without enough exercise, the Otterhound will find ways to entertain himself--ways that are apt to displease you, such as nonstop baying or excavating your newly planted flower garden.\n\n"
                    + "The hardworking Otterhound can be trained to compete in obedience and agility. He excels in tracking, and the percentage of Otterhounds who earn American Kennel Club tracking titles is usually higher each year than for any other breed.\n\n"
                    + "Despite his size, strength, and impressive bark, the Otterhound isn't really suited to guard duty — he's far too friendly to take the job of a watchdog seriously.\n\n"
                },

                new Dog()
                {
                    Name = "Papillon",
                    GroupName = "Companion Dogs",
                    Height = "8-11 inches",
                    Weight = "5-10 pounds",
                    LifeSpan = "14-16 years",
                    CoverImage = "Papillon.jpg",
                    Info = "The Papillon, whose name comes from the French word for butterfly, is a portrait come to life, the modern representation of the small spaniels often seen in paintings from centuries past. The dwarf spaniel, as he was once known, has changed somewhat in appearance over the years, but he's still the same wonderful companion who graced the laps of ladies and kings so many years ago.\n\n"
                    + "The word papillon, meaning 'butterfly,' refers to the breed's fringed upright ears, which resemble a butterfly's outspread wings. The breed also comes in a drop-eared variety called the phalene, which means 'moth,' a cousin of the butterfly that folds its wings at rest. Both varieties can be born in the same litter, although the Papillon is the more popular and recognized variety.\n\n"
                    + "While he might be categorized by size as a lap dog, the bright, busy, and curious Papillon is no shrinking butterfly. If you want a dog to sit on your lap while you watch television, he's probably not the best choice. He's more likely to be flitting around looking for something to do and will happily rid your home and yard of any small rodents that might be lurking there. And this small dog in a sturdy package takes seriously his duties as family companion and guardian. He has a big-dog attitude and a level of alertness that makes him a super watchdog, but when it comes to protecting you it's important to make sure he doesn't bite off more than he can chew. He has no idea that he weighs only 4 to 9 pounds.\n\n"
                    + "The Papillon is outgoing and energetic. He loves to be with people and is a happy dog who gives kisses freely to all. The Papillon's small size makes him easy to handle, and his coat, while profuse, is easy to care for and doesn't shed excessively.\n\n"
                    + "His energy level ranges from moderate to intense, and being highly trainable he's a great choice if you want to participate in dog sports such as agility or rally. Papillons are also excellent competitors in the obedience ring and are the number-one toy breed in obedience competition.\n\n"
                    + "All Papillon owners should attend obedience class if only to ensure that they don't spoil their charming companions. Papillons can develop a stubborn streak if not shown early that such behavior will not be tolerated. On the plus side, their will to please and desire to succeed make them good at learning tricks or anything else a creative person can teach them. Papillons can even learn to pull a tiny cart and will proudly pull it in parades.\n\n"
                    + "Papillons get along well with other pets in the family, including cats, if introduced at a young age. The fearless Papillon will often boss around dogs much bigger than he is, and this may or may not cause problems. It's not unusual for the smallest dog to be the one in charge.\n\n"
                    + "Papillons love children, but the combination of a tiny dog and a young child can be a recipe for disaster. A Papillon may leap from a child's hands and injure himself if he's not being held correctly, and he won't hesitate to defend himself if he's being mistreated. No matter what the breed, dogs and children must always be supervised when they're together.\n\n"
                    + "This is a long-lived breed. It's common for Papillons to live well into their teens, and if you're considering purchasing one you should take that into consideration. The dog will be a member of your family for years to come.\n\n"
                    + "A Papillon made breed history in 1999 when for the first time one took Best In Show at the Westminster Kennel Club show. The dog, Ch. Loteki Supernatural Being, or Kirby to his friends, also won the World Dog Show in Helsinki, Finland, and the Royal Invitational in Canada in 1998. This dog's wins introduced the breed to many who had never seen or heard of the Papillon and has contributed to the breed's rise in popularity. Nonetheless, you won't find a Papillon on every street corner. He's not a rare breed, but he's not common, either. Most breeders have a waiting list because Papillons tend to have small litters.\n\n"
                    + "The Papillon has been bred for centuries to be the ultimate companion. They are extremely people oriented and demand to be included in their person's life at all times. If you are looking for a lively, energetic, outgoing, and gregarious companion this could be the breed for you. You and your Papillon will live happily together for many years.\n\n"
                },

                new Dog()
                {
                    Name = "Pekinese",
                    GroupName = "Companion Dogs",
                    Height = "6-9 inches",
                    Weight = "up to 14 pounds",
                    LifeSpan = "12-14 years",
                    CoverImage = "Pekinese.jpg",
                    Info = "It's no wonder the Pekingese has a self-important attitude, given his history as an imperial favorite. He was held in great esteem at the imperial court of China, and he still knows it today. A Pekingese will greet you with dignity and pride. He is well aware that his ancestors were the companions of royalty and he continues to demand the respect such a position entails today. With his soft round brown eyes, mane of long straight hair and tail carried jauntily over his back, he swaggers through life in full awareness of who he is and the importance he has to the people who live with him.\n\n"
                    + "Pekingese are very intelligent, but that intelligence is offset by an independent mind and a wide stubborn streak. Training them is a challenge. They consider themselves in charge of any situation so you must persuade them that you are in charge and that doing what you want is to their advantage. Pekingese do not respond well to harsh training or discipline and it can cause them to become defensive and possibly to bite.\n\n"
                    + "Pekingese are very loving and affectionate with their family but aloof, almost wary, of strangers. That characteristic makes them excellent watchdogs; they like to bark when strangers approach. Some Pekingese tend to bark too much, so it's a good idea early on to teach them when to stop. They are brave, sometimes to the point of being foolhardy, and will defend you to the death if needed.\n\n"
                    + "While children are always intrigued by small dogs, a Pekingese is not a good choice for families with toddlers who may treat him roughly without meaning to. The Peke won't tolerate being grabbed or poked and won't hesitate to defend himself. Always supervise any interaction between a Pekingese and a child of any age.\n\n"
                    + "Pekes don't always get along with other dogs. They prefer the company of other Pekingese, and it can take them a long time to get used to other animals in the household. With proper socialization — early exposure to many different people, other animals, sights, sounds, and experiences — however, they can become best friends with other dogs and cats and include them in their royal group. Until you're sure everyone gets along, though, supervise any active play. The Peke's round, protuberant eyes are easily injured with the swipe of a paw or claw.\n\n"
                    + "The profuse coat of the Pekingese needs daily to weekly care. The long, flowing coat of the show dog needs daily maintenance, but people who have companion Pekingese can choose to keep their pets' coats trimmed short to ease the burden of grooming.\n\n"
                    + "If you are looking for a devoted, loving friend who will treat you with respect and dignity and expect the same treatment from you, then the Pekingese may be a breed to consider. They need someone who understands their unique needs and who is willing to make room for a truly individual personality in their lives. The Pekingese will return your care with all the love and affection that a truly large heart in a small package can offer.\n\n"
                },

                new Dog()
                {
                    Name = "Pembroke welsh corgi",
                    GroupName = "Herding Dogs",
                    Height = "10-12 inches",
                    Weight = "up to 30 pounds",
                    LifeSpan = "12-13 years",
                    CoverImage = "PembrokeWelshCorgi.jpg",
                    Info = "Welsh Corgis come in two varieties: the Pembroke and the Cardigan. They were registered as one breed by the Kennel Club in the U.K. until 1934, although many breeders believe the two breeds developed separately. Both have similar heads, bodies, levels of intelligence and herding ability, but the Cardigan is slightly larger and heavier boned than the Pembroke.\n\n"
                    + "For most of us, the easiest way to tell the difference between a Pembroke and a Cardigan is to look at the tails. Pembrokes' are docked and Cardigans' are long. (Remember it this way: the Pembroke has a 'broke' tail; the Cardigan has a long tail like the sleeves of a cardigan sweater.)\n\n"
                    + "Pembroke Welsh Corgis (also called Pembrokes, PWCs or Pems) are the smallest of the American Kennel Club's Herding Group, and are also recognized by the United Kennel Club. Their coats can be red, sable, fawn or tri-colored (red, black and tan), usually with white markings on the legs, chest, neck, muzzle and belly. They also may have a narrow blaze on their heads. Pembroke heads are shaped much like the head of a fox. Their eyes are oval-shaped and dark, and their ears are erect.\n\n"
                    + "The official AKC breed standard is maintained by the Pembroke Welsh Corgi Club of America.\n\n"
                },

                new Dog()
                {
                    Name = "Pug",
                    GroupName = "Companion Dogs",
                    Height = "10-13 inches",
                    Weight = "14-18 pounds",
                    LifeSpan = "13-15 years",
                    CoverImage = "Pug.jpg",
                    Info = "The Pug's comical face, with deep wrinkles around big, dark eyes and a flat round face, can't help but make you smile. It is believed that the Pug's name comes from the Latin word for 'fist' because his face resembles a human fist.\n\n"
                    + "Pugs are clowns at heart, but they carry themselves with dignity. Pugs are playful dogs, ready and able for games, but they are also lovers, and must be close to their humans. Pugs love to be the center of attention, and are heartsick if ignored.\n\n"
                    + "Pugs are square and thickset, usually weighing no more than 20 pounds. Their heads are large and round, with large, round eyes. They have deep and distinct wrinkles on their faces. Legend has it that the Chinese, who mastered the breeding of this dog, prized these wrinkles because they resembled good luck symbols in their language. Especially prized were dogs with wrinkles that seemed to form the letters for the word 'prince' in Chinese.\n\n"
                    + "The moles on a Pug's cheeks are called 'beauty spots.' His muzzle or mask is black, with a clearly defined 'thumb mark' on the forehead and a black trace down the center of the back. His ears are smooth, black and velvety. He has a characteristic undershot jaw (the lower teeth extend slightly beyond the upper teeth) and a tightly curled tail.\n\n"
                    + "Personality-wise, Pugs are happy and affectionate, loyal and charming, playful and mischievous. They are very intelligent, however, they can be willful, which makes training challenging.\n\n"
                    + "While Pugs can be good watchdogs, they aren't inclined to be 'yappy,' something your neighbors will appreciate. If trained and well-socialized, they get along well with other animals and children. Because they are a small, quiet breed and are relatively inactive when indoors, they are a good choice for apartment dwellers. Due to the flat shape of the Pug's face, he does not do well in extremely hot or cold weather, and should be kept indoors.\n\n"
                    + "Pugs have a short, double coat, and are known for shedding profusely. If you live with a Pug, it's a good idea to invest in a quality vacuum cleaner!\n\n"
                },

                new Dog()
                {
                    Name = "Redbone",
                    GroupName = "Hound Dogs",
                    Height = "21-27 inches",
                    Weight = "45-70 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "Redbone.jpg",
                    Info = "The merry and gentle Redbone Coonhound descends from red hounds brought to North America by Scottish and Irish immigrants during colonial times. The medium-size, solid-red dogs have the pleading expression common to hounds everywhere and a sweet voice that sings out when they're on the hunt. Unfortunately, they also bark a lot at home, so make sure you live out in the country or have very tolerant neighbors.\n\n"
                    + "Friendly and loyal, Redbone Coonhounds make good companion dogs as long as they get plenty of exercise. Plan to be patient while training this breed; they often suffer from canine attention deficit disorder.\n\n"
                    + "Size\n"
                    + "Males stand 22 to 27 inches at the shoulder; females, 21 to 25 inches. Redbone Coonhounds weigh 45 to 70 pounds.\n\n"
                    + "Coat Color And Grooming\n"
                    + "The Redbone Coonhound coat is short and smooth. The color should be a rich, deep red, but the breed standard allows for a dark muzzle and a small amount of white on the chest and feet.\n\n"
                },

                new Dog()
                {
                    Name = "Rhodesian ridgeback",
                    GroupName = "Hound Dogs",
                    Height = "24-27 inches",
                    Weight = "70-80 pounds",
                    LifeSpan = "~10 years",
                    CoverImage = "RhodesianRidgeback.jpg",
                    Info = "The first thing people notice about the Rhodesian Ridgeback is usually the characteristic ridge that runs down his spine and gives him his name. The ridge reveals part of his heritage, which is a mix of European hunting dogs and African dogs who had the distinctive ridge.\n\n"
                    + "They also notice his strong athleticism, noble carriage, and the intelligence in his eyes. The history of the breed only adds to his allure; owners are often asked, 'Did they really hunt lions?'\n\n"
                    + "The answer is yes, the Ridgeback was developed in Africa to corner and hold big game prey, such as lions, bears, and boar. Today, the Rhodesian Ridgeback is still used for hunting, and some members of the breed have even adapted to pointing and retrieving. The Rhodesian Ridgeback can also be found competing in various dog sports, including agility, lure coursing, obedience, and tracking, and he's a good hiking or jogging companion.\n\n"
                    + "As a pup, the Rhodesian Ridgeback is active and exuberant, but he matures into a dog with moderate exercise needs. Give him a vigorous walk or game of fetch a couple of times a day, plus a chance to run in a safely fenced area a couple of times a week, and he'll be satisfied — at least in terms of physical exercise. This intelligent breed also needs mental stimulation: a bored Rhodesian Ridgeback is a destructive Rhodesian Ridgeback.\n\n"
                    + "The Rhodesian Ridgeback is dignified and reserved toward strangers. With his family, he's a quiet, gentle companion, one who's able and willing to defend his home and people if the need arises.\n\n"
                    + "Because of his size, intelligence, and power, he's not the breed for everyone. First-time or timid dog owners may find him to be much more than a handful. People who want an outgoing dog who will love everyone should keep looking. But if you are looking for a strong, confident dog, a dog who encompasses gentleness, hardheadedness, and a sense of humor in a shorthaired, easy-care package, the Rhodesian Ridgeback may be the perfect match.\n\n"
                },

                new Dog()
                {
                    Name = "Rottweiler",
                    GroupName = "Working Dogs",
                    Height = "22-27 inches",
                    Weight = "80-135 pounds",
                    LifeSpan = "9-10 years",
                    CoverImage = "Rottweiler.jpg",
                    Info = "Like the mythical Greek hero Hercules, the Rottweiler is strong and true with a loving heart. Affectionately called Rotties or Rotts, the breed originated in Germany, where it was used to drive cattle and pull carts for farmers and butchers. That heritage is reflected in the Rottie's broad chest and heavily muscled body. When he moves, he displays strength and stamina, but when you look into his eyes you see warm, dark-brown pools reflecting a mellow, intelligent, alert, and fearless expression.\n\n"
                    + "A well-bred Rottweiler is calm and confident. He's typically aloof toward strangers, but never timid or fearful. Rottweilers exhibit a 'wait-and-see' attitude when confronted with new people and situations. When these characteristics come together as they should, the Rottweiler is a natural guard dog with a mellow disposition who is successful not only in police, military, and customs work, but also as a family friend and protector.\n\n"
                    + "Rotties have a natural instinct to protect their families and can be ferocious in their defense. It's essential to channel their power and protectiveness by providing early socialization, firm, fair, consistent training and leadership, and a regular job to perform. When this doesn't happen, Rottweilers can become dangerous bullies rather than the companionable guardians they're meant to be.\n\n"
                    + "Rottweilers walk a fine line between protectiveness and aggressiveness. If they aren't carefully bred for a calm, intelligent temperament and properly socialized and trained, they can become overly protective. That might sound like what you want, but a Rottie who lacks the ability to discriminate is dangerous to everyone he encounters, not just the bad guys.\n\n"
                    + "You must be able to provide your Rottweiler with leadership he can trust and respect without resorting to anger or physical force. Otherwise, he'll take the role of top dog for himself. With a dog as powerful and intelligent as the Rottweiler, this is a recipe for disaster.\n\n"
                    + "Despite what you might have heard, Rottweilers are not temperamentally unsound or inherently vicious. Well-bred, well-socialized Rotties are playful, gentle, and loving to their families. They are easy to train if treated with respect and make great companions.\n\n"
                    + "As wonderful as Rottweilers can be, they aren't the dog for everyone. You must not only be dedicated to training and socializing your Rottie, you must also deal with people who don't understand the breed and pre-judge it. Because of bad or tragic experiences with Rottweilers or other large breeds, some cities have banned the breed. It's unfair to judge an entire breed by the actions of a few, but it's a reality you will have to deal with if you own a Rottweiler.\n\n"
                    + "You can do your part to redeem the reputation of the breed by training your Rottweiler to obey and respect people. Most important, don't put your Rottie in the backyard and forget about him. This is a dog who is loyal to his people and wants to be with them. If you give him the guidance and structure he needs, you'll be rewarded with one of the finest companions in the world.\n\n"
                },

                new Dog()
                {
                    Name = "Scottish deerhound",
                    GroupName = "Hound Dogs",
                    Height = "28-32 inches",
                    Weight = "75-110 pounds",
                    LifeSpan = "8-11 years",
                    CoverImage = "ScottishDeerhound.jpg",
                    Info = "Affectionately known as the 'Royal Dog of Scotland,' it is not difficult to imagine how this breed, with its athletic, well-muscled build, came by the title. The Scottish Deerhound has a romantic past, a noble bearing, and a loving nature, so much so that Sir Walter Scott — himself the owner of deerhound named Maida — described the breed as 'the most perfect creature of Heaven.'\n\n"
                    + "What is the allure of this large dog, with his wiry coat and greyhound-type build? Much of it can't be answered in words but must be witnessed firsthand. The Scottish Deerhound is affectionate toward everyone — family, friends, and strangers alike. He loves children and usually does well with other dogs, although the larger the better. With his long legs, he enjoys a nice jog with a human companion, but afterward is happy to laze around on the sofa and snooze in a sunny spot.\n\n"
                    + "This gentle dog has an elegant and polite air but is never aloof. While he's undoubtedly loyal and courageous, he doesn't make the best watchdog. His size might be intimidating to someone who doesn't know him, but he's too loving and friendly to pose any threat, and it rarely occurs to him to bark when someone approaches his home. He's highly active as a puppy, but by the time he's 3 to 5 years old he morphs into a couch potato. Nonetheless, he still requires long walks daily to maintain his tall, gangly body.\n\n"
                    + "The Scottish Deerhound is kind enough for people who are inexperienced with dogs, but even a novice should understand that he's not the easiest breed to train. Deerhounds are lazy and approach training with a 'What's in it for me?' attitude. Although they have a reputation for not doing well in obedience or agility competitions, they can succeed in these arenas if their trainers are willing to put in hard work and consistent training. Scottish Deerhounds may also be slower than other breeds when it comes to housetraining, but the same patience and consistency that gives you a well-trained dog will be an asset with this step in training.\n\n"
                    + "Scottish Deerhounds are not recommended for apartment living despite their calm indoor nature. They do best when they have a large yard to run in, and the yard should be fenced to prevent them from chasing 'prey' into the street. Underground electronic fencing should not be used with this breed; no shock will stop them once they go into chase mode. They're best suited to homes without cats or other small pets that may trigger their prey drive.\n\n"
                    + "If you can meet the special needs of a giant breed built for speed, the Scottish Deerhound is a devoted companion who will fill your life with all the love his large and dignified heart can give.\n\n"
                },

                new Dog()
                {
                    Name = "Shih tzu",
                    GroupName = "Hybrid Dogs",
                    Height = "9-12 inches",
                    Weight = "6-12 pounds",
                    LifeSpan = "12-14 years",
                    CoverImage = "ShihTzu.jpg",
                    Info = "Originally bred to be completely nonshedding (which is a misnomer since that's not physically possible), the Maltese succeeds to some degree, since he's a low-shedding companion. However, the Maltese Shih Tzu is much more than that.\n\n"
                    + "He's intelligent and happy, making him a breeze — and a pleasure — to train. He does well as a therapy dog, and his wonderfully social nature makes him a great family pet. He's good with children of all ages and with other dogs and pets.\n\n"
                    + "This extrovert is gutsy and gregarious, and he loves people of any age group. The Maltese can be high-strung and snappy, but when crossed with the aloof Shih Tzu, you can get a friendly and outgoing dog who's good with people. Like any dog, this cross needs to be socialized as a puppy and as an adult.\n\n"
                    + "He also needs to be treated like a dog rather than like a baby or a stuffed animal who eats; that's why most dogs this size become little tyrants. It's not their nature so much as that they're allowed to be brats — but if you treat your Maltese Shih Tzu like a real dog, he'll act like a real dog. Make him walk, don't carry him everywhere, and he'll have the nice temperament he was meant to have.\n\n"
                    + "The Maltese Shih Tzu may look like one either of the parent breeds, but he doesn't usually have the Shih Tzu's short nose and bulging eyes. A Maltese is prone to tearstaining, but the stains — while still there — can't be seen as easily in this crossbreed, probably because the dogs aren't pure white.\n\n"
                    + "He's an affectionate companion who loves being with his family. He's not recommended for homes where he'd be left alone for long periods at a time, since he can suffer from separation anxiety, like most companion breeds.\n\n"
                    + "The Maltese Shih Tzu can be active, but he can also adapt to quieter living. He requires some exercise each day through either a walk or a good play session in the yard. He loves being outside and although he makes an acceptable apartment resident, he does much better with a small yard to romp in.\n\n"
                    + "The Maltese Shih Tzu can have respiratory problems, thanks to that flat-faced Shih Tzu heritage, so he's best suited for homes with air-conditioning since heat can aggravate any problems. He shouldn't be overexercised on hot and humid days.\n\n"
                    + "The Maltese Shih Tzu has proven that he's an adaptable, happy, and loving companion. He's a wonderful choice for elderly people, first-time owners, or any dog fancier who wants a cheerful pal to fill the days with laughter and smiles.\n\n"
                },

                new Dog()
                {
                    Name = "Staffordshire bull terrier",
                    GroupName = "Terrier Dogs",
                    Height = "14-16 inches",
                    Weight = "24-38 pounds",
                    LifeSpan = "12-14 years",
                    CoverImage = "StaffordshireBullTerrier.jpg",
                    Info = "The Staffordshire Bull Terrier can be an imposing dog with its strong, muscular body, intense stare, and powerful stance. Many are interested in the breed because it looks like a tough dog but are surprised to learn that the Stafford is a sensitive and loving companion who enjoys playing more than being tough. He sees life as a joyful adventure and lives it to the fullest.\n\n"
                    + "Fans love the Staffordshire Bull Terrier for his small to medium size, short, easy-care coat, and dynamic yet gentle personality. With his short, broad head and muscular body, he resembles the other bull breeds such as American Staffordshire Terriers and American Pit Bull Terriers, but he is a breed unto himself with distinct physical characteristics that set him apart, including size and ear shape.\n\n"
                    + "The Stafford is known for his love of people and trustworthy nature. He has been described as 'a sort of everybody's Man Friday,' and his greatest desire is to spend time with his people, whether that means vegging out on the sofa and watching football, running errands in the car, going for walks, or participating in activities such as agility, flyball, obedience, and therapy work. Expect to give this athletic and energetic dog a vigorous walk every day, as well as plenty of attention during downtime. He dislikes being left to his own devices. Staffordshire Bull Terriers are not a breed that can be left outside alone or at home for long periods of time without human companionship.\n\n"
                    + "Nicknamed the nanny dog, the Stafford is prized for his patience with and love of children, although it goes without saying that no dog should ever be left alone with young children or expected to double as a baby-sitter. He is not always so friendly toward dogs he doesn't know however, a remnant of his origin as a fighting breed, which required him to be aggressive toward other dogs yet gentle with human handlers.\n\n"
                    + "Be aware that some municipalities restrict the ownership of bull breeds. Be sure that yours is not one of them before acquiring a Stafford. For the person who has an understanding of his sensitive nature and can give him patient, firm leadership, the Stafford is one of the finest dog companions around.\n\n"
                },

                new Dog()
                {
                    Name = "Toy terrier",
                    GroupName = "Companion Dogs",
                    Height = "8.5-11.5 inches",
                    Weight = "3-7 pounds",
                    LifeSpan = "13-15 years",
                    CoverImage = "ToyTerrier.jpg",
                    Info = "The Toy Fox Terrier (TFT) was developed in the United States, making him one of only a few breeds that are truly 'All American.' He was created from small Smooth Fox Terriers bred with several toy breeds — including Chihuahuas and Manchester Terriers — to set breed size. He's a true terrier, with fire, heart and spirit to go out in the field hunting squirrel, and a true toy dog, a diminutive, loving companion who will curl up on the sofa and watch TV with his people.\n\n"
                    + "Toy Fox Terriers are highly intelligent. They housetrain easily as puppies and their small size makes them suited to using a canine litter box or housetraining pad. Obedience and other canine activities come easily to them as well, perhaps a vestige of their heritage. TFTs did acrobatics, walked tightropes and performed other circus dog tricks in the small dog and pony shows that once traveled the country. Today, they are shown in conformation and do quite well in obedience and agility trials, rally, and flyball.\n\n"
                    + "A hardy breed, Toy Fox Terriers can be expected to live into their teens, remaining active into old age.\n\n"
                    + "Toy Fox Terriers are extremely loyal to and protective of their family. They make excellent watchdogs with a large bark that belies their size. They are persistent in their protection efforts, making smart burglars decide to take on a less noisy target.\n\n"
                    + "This dog bonds tightly with his family and demands to be included in all activities. Sometimes you might question whether the Toy Fox Terrier considers himself a dog. He has abundant energy and is eager to please, but has a mind of his own that makes him insist on rights and privileges given to other family members, such as sleeping on the bed.\n\n"
                    + "His intense loyalty to his family can make him aloof with strangers, but socialization and training to accept strangers should help your dog to realize there is no danger from visitors you allow in your home.\n\n"
                    + "The Toy Fox Terrier until recently had been only a recognized breed in the United Kennel Club (UKC), but the American Kennel Club (AKC) and the Canadian Kennel Club (CKC) have now granted registration and full show status to the breed. This will give the TFT many more opportunities to gain fans and admirers for his lively disposition, loyalty, spirit, and intelligence, not to mention his sleek good looks. People who have been owned by this breed feel that their family is not complete without one around.\n\n"
                },

                new Dog()
                {
                    Name = "Vizsla",
                    GroupName = "Sporting Dogs",
                    Height = "21-23 inches",
                    Weight = "45-60 pounds",
                    LifeSpan = "12-14 years",
                    CoverImage = "Vizsla.jpg",
                    Info = "This breed is often described as the 'Velcro Vizsla.' Most dogs are affectionate, but this medium-size hunting dog is especially attached to his people.\n\n"
                    + "His Velcro nature has to do with his past: the Vizsla was developed in Hungary to be both a pointer and retriever who would work close to the hunter, never ranging too far away. That trait is still seen in today's Vizsla, who prefers to be leaning against your leg or serving as a footwarmer. If having a dog shadow you all day would annoy you, choose a different breed.\n\n"
                    + "Despite their penchant for sticking close to their human pals, Vizslas are versatile and hard-working dogs who are happiest when they have a job to do. In a family, that job can be hunting companion, therapy dog, or jogging buddy. Give him at least an hour of exercise per day, and the Vizsla will be your best friend.\n\n"
                    + "If you're interested in dog sports and activities, your Vizsla would probably be happy to compete. The Vizsla is the first and so far only breed to produce a quintuple champion — in conformation, field, obedience and agility. His superb scenting skills make him a natural hunter. Vizslas have also been guide dogs, drug-detection dogs, therapy dogs, and search-and-rescue dogs, and have competed in falconry, flyball, tracking, and hunt tests.\n\n"
                    + "Whatever you do with your Vizsla, train this sensitive dog with kindness and positive reinforcement. He's quick to learn, and his keen senses and protective instinct make him an excellent watchdog.\n\n"
                    + "Vizslas are talkers, and will whine, moan, or make other noises to let you know their opinion on everything that's going on. Some can become recreational barkers if this habit isn't controlled early on.\n\n"
                    + "Not surprisingly, the best home for a Vizsla is one in which someone is there during the day to keep him company and give him the activity and mental stimulation he needs. Without them, he can become bored and destructive. With the right family, however, he's a lively, loving, gentle friend who will return tenfold the love you give him.\n\n"
                },

                new Dog()
                {
                    Name = "Walker hound",
                    GroupName = "Hound Dogs",
                    Height = "20-27 inches",
                    Weight = "50-70 pounds",
                    LifeSpan = "12-13 years",
                    CoverImage = "WalkerHound.jpg",
                    Info = "Descended from English Foxhounds and formerly classified as an English Coonhound, the Treeing Walker earned his name by trailing game faster than other coonhounds and then treeing it until the hunter arrived. The Walker part of the name comes from Kentuckian John W. Walker, who helped develop the breed.\n\n"
                    + "This classic tricolor hound has a racy build, a short, clear bark, and a strong desire to hunt. Personalities range from outgoing to bashful to protective. Like any hound, the Treeing Walker requires patient, consistent training and plenty of daily exercise.\n\n"
                    + "Size\n"
                    + "Males stand 22 to 27 inches at the shoulder; females, 20 to 25 inches. Weight ranges from 45 to 80 pounds.\n\n"
                    + "Coat Color And Grooming\n"
                    + "The smooth and shiny tricolor coat can be white with black spots and tan markings, or black with white markings and tan trim, known as saddleback or blanketback.\n\n"
                },

                new Dog()
                {
                    Name = "Weimaraner",
                    GroupName = "Sporting Dogs",
                    Height = "23-27 inches",
                    Weight = "55-90 pounds",
                    LifeSpan = "10-13 years",
                    CoverImage = "Weimaraner.jpg",
                    Info = "Your first exposure to the Weimaraner may have been through the photographs, calendars, and books of William Wegman, a photographer who uses wigs, costumes, and props to capitalize on the breed's ability to assume almost human expressions. His ever-patient Weimaraners have impersonated Louis XIV, posed in bed watching television, and appeared as Little Red Riding Hood.\n\n"
                    + "But the Weimaraner's earliest job was to serve as an all-around hunting dog who handled big game such as deer, bear, and wolves. As Germany's forests shrank and big game became scarce, the Weimaraner's handlers turned the breed's talents to hunt birds, rabbits and foxes.\n\n"
                    + "He takes his name from the place in Germany where he was developed — the Court of Weimar, whose noblemen wanted a dog with courage married to intelligence, one with good scenting ability and speed and stamina on the trail.\n\n"
                    + "How they achieved their dream dog, first known as the Weimar Pointer, is unknown, but it's believed that the breeds bred to create the Weimaraner include the Bloodhound, the English Pointer, the German Shorthaired Pointer, the blue Great Dane, and the silver-gray Huehnerhund, or chicken dog.\n\n"
                    + "Today, Weimaraners are affectionately called Weims, Silver Ghosts, or Gray Ghosts. Part of their appeal lies in their sleek mouse-gray to silver-gray coat and light amber, blue-gray, or gray eyes. But there's far more to the Weimaraner than his distinctive appearance. The elegant, aristocratic dogs are loving and devoted.\n\n"
                    + "A Weimaraner's first desire is to be with his people, preferably within touching range. It's not for nothing that many Weimaraners bear the name Shadow. They'll lie at your feet or follow you through the house.\n\n"
                    + "Weimaraners aren't the breed for everyone, however. First-time dog owners need not apply. These dogs have a great deal of energy and stamina and need a lot of exercise and mental stimulation. Without it, they're likely to become nervous and high-strung. They can be quite a handful, with loads of energy to burn, and the intelligence to figure out how to get into trouble all on their own!\n\n"
                    + "Because they're hunting dogs, Weimaraners have a strong prey drive. If not trained or kept under control, they'll chase and kill anything that resembles prey, including cats and small dogs, mice, frogs, birds, and more. They will then proudly present you with their trophies. They'll also chase joggers and bicyclists.\n\n"
                    + "Despite their hunting instincts, Weimaraners are house dogs (like most dogs). They're temperamentally unsuited to living in a kennel or being kept in the backyard with little human interaction.\n\n"
                    + "Weims are independent thinkers and will constantly test your boundaries. If you haven't owned a Weimaraner before, you'll do well to attend puppy kindergarten followed by obedience class. Training should be gentle and firm, however, because harsh treatment will make him resentful.\n\n"
                    + "Once he's trained, the Weimaraner is a versatile dog who can be an up-close-and-personal hunting companion, compete in agility, and be a fine family friend.\n\n"
                },

                new Dog()
                {
                    Name = "Whippet",
                    GroupName = "Hound Dogs",
                    Height = "18-22 inches",
                    Weight = "25-40 pounds",
                    LifeSpan = "12-15 years",
                    CoverImage = "Whippet.jpg",
                    Info = "Nicknamed the 'poor man's Greyhound,' the elegant yet powerful Whippet was probably created some time in the late 18th century for use by poachers in search of rabbits and other small game, as well as in 'snap' contests, in which the goal was for the dog to snap up rabbits in a circle. They really came into their own, however, when it was discovered that they would chase a waving rag, and Whippet racing became popular among working class men.\n\n"
                    + "This medium-size hound has a short, dense coat in a variety of colors and markings covering a streamlined body. The Whippet is not a miniature Greyhound but was developed by crossing Greyhounds with smaller terriers and, later, Italian Greyhounds. The result was a sleek and beautiful dog who's gentle and affectionate.\n\n"
                    + "The Whippet is often called the perfect all-purpose dog and is a keen competitor in agility, flyball, and lure coursing. Although they're known for their independent temperament, which can make obedience training challenging, plenty of Whippets compete successfully in obedience trials.\n\n"
                    + "The Whippet usually gets along with other dogs and people, although early socialization — exposure to different people, sights, sounds, and situations — is necessary to keep your Whippet from becoming fearful of new situations. If you're fond of cats, however, the Whippet may not be the best choice. This breed has a strong prey drive. Although some Whippets can live peacefully with cats and other small furry pets, there have been cases of Whippets killing family cats. You may be able to train and socialize your Whippet to accept the family cat, but it's important to always supervise their interactions and never leave them alone together.\n\n"
                    + "That same prey drive that makes Whippets unsuitable to homes with cats makes them unsuitable to walks off leash. They will give chase if they see something worth chasing, and even a well-trained Whippet will disregard commands to come. Some have pursued prey for miles.\n\n"
                    + "Whippets enjoy daily walks, and an opportunity to run in a fenced yard or other confined area is always appreciated. An underground electronic fence is not sufficient to keep them contained; they'll ignore the shock it gives in favor of going after any moving object.\n\n"
                    + "In the home, they're gentle and undemanding, asking only to enjoy your company. With children they're playful and mischievous. Their thin coats and affectionate nature make them unsuited to living outdoors. Whippets will snuggle with you on the sofa and warm your feet in bed at the end of an active day.\n\n"
                },

            };


            foreach (Dog item in GlobalVariables.Dogs)
            {
                try
                {
                    GlobalVariables.dict.Add(item.Name, (item.GroupName, item.Height, item.Weight, item.LifeSpan, item.CoverImage, item.Info));
                }
                catch (Exception)
                {


                }
            }
            Dogs2 = GlobalVariables.Dogs.ToList();

        }
    }
}
