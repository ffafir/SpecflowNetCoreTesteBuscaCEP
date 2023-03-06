Feature: InformarCEP
	Informar um cep para buscar informação



@Testes1
Scenario: Procurar CEP inexistente
	Given eu tenha acessado o site dos correios
	And Clicado no campo de preenchimento do CEP
	And tenha preenchido o campo com o valor
		| CEP      |
		| "80700000" |
	When o ícone de buscar for selecionado
	Then deverá ser exibido uma mensagem informado que o CEP não existe
