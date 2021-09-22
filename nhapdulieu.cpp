#include<stdio.h>
#include<iostream>
using namespace std;
int main(int argc, char ** argv)
{
	int n;
	cout<<"nhap so phan tu: ";
	cin>>n;
	int M[n];
	int i=0;
	while(i<n)
	{
		cout<<"Nhap M["<<i<<"]=";
		cin>>M[i];
		if(i>0 && M[i+1]<=M[i])
			continue;
		i++;
	}
	cout<<"Du lieu ban vua nhap\n";
	for(int i=0;i<n;i++)
		cout<<M[i]<<"\t";
	return 0;
}

