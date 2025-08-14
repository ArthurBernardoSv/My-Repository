class Livro:
    def __init__(self, titulo, autor, total_paginas):
        self.titulo = titulo
        self.autor = autor
        self.total_paginas = total_paginas
        self.pagina_atual = 0

    def abrir_livro(self):
        self.pagina_atual = 1
        print(f"Você começou a ler '{self.titulo}' de {self.autor}.")

    def ler_paginas(self, paginas):
        if self.pagina_atual == 0:
            print("Você precisa abrir o livro primeiro!")
            return

        if self.pagina_atual + paginas <= self.total_paginas:
            self.pagina_atual += paginas
        else:
            self.pagina_atual = self.total_paginas

        print(f"Você leu {paginas} páginas.")

    def exibir_progresso(self):
        if self.pagina_atual == 0:
            print("O livro ainda não foi aberto.")
        else:
            restante = self.total_paginas - self.pagina_atual
            print(f"Página atual: {self.pagina_atual} de {self.total_paginas}.")
            print(f"Faltam {restante} páginas para terminar.")

# Usando a classe Livro
def main():
    meu_livro = Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 96)
    meu_livro.abrir_livro()
    meu_livro.ler_paginas(10)
    meu_livro.exibir_progresso()

# Executa o programa
if __name__ == "__main__":
    main()
