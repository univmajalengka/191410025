import java.util.*;
import java.util.HashMap;
public class bilangan {

public static void main(String[] args) {       
    	int []a = {2,45,7,3,5,1,8,9};
    	System.out.println("");
    	System.out.println("========= Menemukan Nomor Duplikat ==========");
	System.out.println("===== Pada Larik Bilangan Bulat Tertentu ====");
	System.out.println("================ Versi JAVA =================");
	System.out.println("*********************************************");
	System.out.println("Inptut Statis Konstant = 2,45,7,3,5,1,8,9 , Dengan SUM = 10 ");
	System.out.println("Hasil = ");
   	printSumPairs(a,10);        
}

public static void printSumPairs(int []input, int k){
    	Map<Integer, Integer> pairs = new HashMap<Integer, Integer>();
    	for(int i=0;i<input.length;i++){
        if(pairs.containsKey(input[i]))
            System.out.println(input[i] +", "+ pairs.get(input[i]));
        else
            pairs.put(k-input[i], input[i]);
    }
}
}
