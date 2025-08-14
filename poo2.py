class ContaBancaria:
    def __init__(self, titular, numero_conta):
        """
        Método construtor que inicializa os dados da conta.
        """
        self.titular = titular
        self.numero_conta = numero_conta
        self.saldo = 0  # Saldo inicial é zero

    def depositar(self, valor):
        """
        Adiciona valor ao saldo.
        """
        if valor > 0:
            self.saldo += valor
            print(f"Depósito de R$ {valor:.2f} realizado com sucesso.")
        else:
            print("Valor de depósito deve ser positivo.")

    def sacar(self, valor):
        """
        Remove valor do saldo, se houver saldo suficiente.
        """
        if valor <= self.saldo:
            self.saldo -= valor
            print(f"Saque de R$ {valor:.2f} realizado com sucesso.")
        else:
            print("Saldo insuficiente para saque.")

    def consultar_saldo(self):
        """
        Exibe o saldo atual.
        """
        print(f"Saldo atual: R$ {self.saldo:.2f}")

    def exibir_extrato(self):
        """
        Mostra informações da conta.
        """
        print("Extrato da Conta:")
        print(f"Titular: {self.titular}")
        print(f"Número da Conta: {self.numero_conta}")
        print(f"Saldo: R$ {self.saldo:.2f}")

# Usando a classe ContaBancaria
def main():
    # Criando uma conta
    minha_conta = ContaBancaria("Maria Silva", "12345-6")

    # Realizando operações
    minha_conta.depositar(500)
    minha_conta.consultar_saldo()
    minha_conta.sacar(200)
    minha_conta.consultar_saldo()
    minha_conta.exibir_extrato()

# Executa o programa
if __name__ == "__main__":
    main()
