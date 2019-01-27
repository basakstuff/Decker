using System;

namespace prj
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s1,s2,s3,a1,a2,a3;
			int n1=0,n2=0,n3=0,con=0,family1=1,family2=1,family3=1,err=0,sum=0,ss=0,ds=0,p1=0,p2=0,p3=0,p4=0,p5=0,p6=0,p7=0,p8=0,yac=0;
			
/*/////////////     READ INPUTS FROM USER	   /////////////////////////*/
			Console.Write("Enter the suit of first card: ");
			s1=Console.ReadLine();
			Console.Write("Enter the number of first card: ");
			a1=Console.ReadLine();
			Console.Write("Enter the suit of second card: ");
			s2=Console.ReadLine();
			Console.Write("Enter the number of second card: ");
			a2=Console.ReadLine();
			Console.Write("Enter the suit of third card: ");
			s3=Console.ReadLine();
			Console.Write("Enter the number of third card: ");
			a3=Console.ReadLine();
			
/*/////////    CONVERTING FAMILY ROYAL TO NUMBER      //////////////////*/
			if(a1=="1") a1="a"; if(a1=="11") a1="j"; if(a1=="12") a1="q"; if(a1=="13") a1="k";
			if(a2=="1") a2="a"; if(a2=="11") a2="j"; if(a2=="12") a2="q"; if(a2=="13") a2="k";
			if(a3=="1") a3="a"; if(a3=="11") a3="j"; if(a3=="12") a3="q"; if(a3=="13") a3="k";
			
			if(a1=="J" || a1=="j") a1="11";
			else if(a1=="Q" || a1=="q") a1="12";
			else if(a1=="K" || a1=="k") a1="13";
			else if(a1=="A" || a1=="a"){ a1="1"; family1=0; }
			else if(a1!="2" && a1!="11" && a1!="12" && a1!="13" && a1!="3" && a1!="4" && a1!="5" && a1!="6" && a1!="7" && a1!="8" && a1!="9" && a1!="10") err=1;
			else family1=0;
			if(a2=="J" || a2=="j") a2="11";
			else if(a2=="Q" || a2=="q") a2="12"; 
			else if(a2=="K" || a2=="k") a2="13";
			else if(a2=="A" || a2=="a"){ a2="1"; family2=0; }
			else if(a2!="2" && a2!="11" && a2!="12" && a2!="13" && a2!="3" && a2!="4" && a2!="5" && a2!="6" && a2!="7" && a2!="8" && a2!="9" && a2!="10") err=1;
			else family2=0;
			if(a3=="J" || a3=="j") a3="11";
			else if(a3=="Q" || a3=="q") a3="12";
			else if(a3=="K" || a3=="k") a3="13";
			else if(a3=="A" || a3=="a"){ a3="1"; family3=0; }
			else if(a3!="11" && a3!="12" && a3!="13" &&  a3!="2" && a3!="3" && a3!="4" && a3!="5" && a3!="6" && a3!="7" && a3!="8" && a3!="9" && a3!="10") err=1;
			else family3=0;
			
		
/*/////////////    DETERMINE IF INPUTS VALID OR NOT	    ///////////////////*/		
			if(err==1||(s1==s2 && a1==a2)||(s1==s3 && a1==a3)||(s2==s3 & a2==a3)||(s1!="H" && s1!="D" && s1!="C" && s1!="S" && s1!="h" && s1!="d" && s1!="c" && s1!="s")||(s2!="H" && s2!="D" && s2!="C" && s2!="S" && s2!="h" && s2!="d" && s2!="c" && s2!="s")||(s3!="H" && s3!="D" && s3!="C" && s3!="S" && s3!="h" && s3!="d" && s3!="c" && s3!="s"))
				Console.WriteLine("please enter the valid values");
			else
			{
/*/////////    CONVERTING STRING NUMBERS TO INTEGER NUMBERS   /////////////*/
				n1=Convert.ToInt32(a1);
			    n2=Convert.ToInt32(a2);
			    n3=Convert.ToInt32(a3);
			    
/*//////////////////    OPTIMIZE THE SUIT VALUES    //////////////////////*/ 
				if(s1=="h") s1="H";    if(s1=="s") s1="S";     if(s1=="c") s1="C";    if(s1=="d") s1="D";
				if(s2=="h") s2="H";    if(s2=="s") s2="S";     if(s2=="c") s2="C";    if(s2=="d") s2="D";
				if(s3=="h") s3="H";    if(s3=="s") s3="S";     if(s3=="c") s3="C";    if(s3=="d") s3="D";
				
/*//////////    DETERMINE IF CARDS CONSECUTIVE OR NOT    ////////////////*/
				if(((n1 == n2 + 1) && (n2 == n3 + 1)) || ((n1 == n3 + 1) && (n3 == n2 + 1)) || ((n2 == n1 + 1) && (n1 == n3 + 1)) || ((n2 == n3 + 1) && (n3 == n1 + 1)) || ((n3 == n1 + 1) && (n1 == n2 + 1)) || ((n3 == n2 + 1) && (n2 == n1 + 1))) con=1;
				if(n1==12 && n2==13 && n3==1) con=1;
				if(n1==12 && n3==13 && n2==1) con=1;
				if(n2==12 && n1==13 && n3==1) con=1;
				if(n2==12 && n3==13 && n1==1) con=1;
				if(n3==12 && n1==13 && n2==1) con=1;
				if(n3==12 && n2==13 && n1==1) con=1;
				
/*//////////    DETERMINE IF ALL CARDS HAVE SAME SUIT    ////////////////*/
				if (s1==s2 && s2==s3 && s1==s3) ss=1;
				
/*////////    DETERMINE IF ALL CARDS HAVE DIFFERENT SUIT  ///////////////*/
				if (s1!=s2 && s2!=s3 && s1!=s3) ds=1;
		
/*/////////////////     EVALUATING THE POINT     ///////////////////////*/				
				if(con==1 && ss==1){ sum+=100; p1=1; yac++;}
				if(n1==n2 && n2==n3){ sum+=80; p2=1; yac++;}
				if(con==1 && ds==1) { sum+=20; p3=1;  yac++;}
				if(family1==1 && family2==1 && family3==1) { sum+=10; p4=1; yac++;}
				if(con==0 && ss==1) { sum+=5; p5=1; yac++;}
				if(n1+n2+n3==21) { sum+=4; p6=1; yac++;}
				if(n1%2==n2%2 && n2%2==n3%2) { sum+=2; p7=1; yac++;}
				if(ds==1) { sum+=1; p8=1; yac++;}
				
/*////////////////    WRITING THE TOTAL POINT     /////////////////////*/				
				Console.Write("You win "+sum+" points !!     ");
				
/*/////////  	WRITING ALL POINTS WHICH COME FROM RULES     //////////*/		
				if(yac>1)
				{
					Console.Write("(");
					if (p1 == 1)
						Console.Write("100 ");
					if (p2 == 1)
						if (p1 == 1)
							Console.Write("+ 80 ");
						else
							Console.Write("80 ");
					if (p3 == 1)
						if (p2 == 1 || p1 == 1)
							Console.Write("+ 20 ");
						else
							Console.Write("20 ");
					if (p4 == 1)
						if (p3 == 1 || p2 == 1 || p1 == 1)
							Console.Write("+ 10 ");
						else
							Console.Write("10 ");
					if (p5 == 1)
						if (p4 == 1 || p3 == 1 || p2 == 1 || p1 == 1)
							Console.Write("+ 5 ");
						else
							Console.Write("5 ");
					if (p6 == 1)
						if (p5 == 1 || p4 == 1 || p3 == 1 || p2 == 1 || p1 == 1)
							Console.Write("+ 4 ");
						else
							Console.Write("4 ");
					if (p7 == 1)
						if (p6 == 1 || p5 == 1 || p4 == 1 || p3 == 1 || p2 == 1 || p1 == 1)
							Console.Write("+ 2 ");
						else
							Console.Write("2 ");
					if (p8 == 1)
						if (p7 == 1 || p6 == 1 || p5 == 1 || p4 == 1 || p3 == 1 || p2 == 1 || p1 == 1)
							Console.Write("+ 1 ");
						else
							Console.Write("1 ");

            		Console.Write(")");
				}
			}
			Console.ReadKey(true);
			
		}
	}
}