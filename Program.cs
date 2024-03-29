﻿using System;
using System.Collections.Generic;

using CSharp.Fundamentos;
using CSharp.EstruturasDeControle;
using CSharp.ClassesEMetodos;
using CSharp.Colecoes;
using CSharp.OO;
using CSharp.MetodosEFuncoes;


namespace CSharp
{
    class Program {
        public static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If-Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If-Else-If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GetAndSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Atributos ReadOnly - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", ExemplosEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Atribuição Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia(Ref/Out) - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", ColecoesArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesStack.Executar},     

                // Orientação Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstração - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},
              
                //Métodos & Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas e Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegates como Função Anônima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                  
            });

                 central.SelecionarEExecutar();
        }
    }
}
 