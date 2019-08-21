using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CopyFiles {
    public partial class Form1 : Form {
        string path1 = "";
        string path2 = "";
        string path3 = "";
        string path4 = "";
        string path5 = "";
        string[] masWithOgr;
        public Form1() {
            InitializeComponent();
        }

        private void Search1_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                path1 = folderBrowserDialog.SelectedPath;
                Path1.Text = path1;
            }
                
        }

        private void Search2_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                path2 = folderBrowserDialog.SelectedPath;
                Path2.Text = path2;
            }
        }

        private void Search3_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                path3 = folderBrowserDialog.SelectedPath;
                Path3.Text = path3;
            }
        }

        private void Search4_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                path4 = folderBrowserDialog.SelectedPath;
                Path4.Text = path4;
            }
        }

        private void Search5_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = false,
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                path5 = folderBrowserDialog.SelectedPath;
                Path5.Text = path5;
            }
        }

        Thread thread, thread1;
        bool flag1 = false;
        private void ToChangeFile_Click(object sender, EventArgs e) {
            flag1 = true;
            flag2 = true;
            thread.Abort();
            thread1.Abort();
            using (FileStream stream = new FileStream("config.txt", FileMode.Truncate)) {
                using (StreamWriter writer = new StreamWriter(stream)) { 
                    writer.WriteLine(path1);
                    writer.WriteLine(path2);
                    writer.WriteLine(path3);
                    writer.WriteLine(path4);
                    writer.WriteLine(path5);
                    writer.Write(Expansion.Text);
                }
            }
            path1 = "";
            path2 = "";
            path3 = "";
            path4 = "";
            path5 = "";
            CheckPath();
        }
        string[] parametrs;
        private void Form1_Load(object sender, EventArgs e) {
            CheckPath();
        }

        void CheckPath() {
            if (path1 == "" && path2 == "" && path3 == "" && path4 == "" && path5 == "") {
                using (FileStream stream = new FileStream("config.txt", FileMode.Open)) {
                    using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.Default)) {
                        string line = "";
                        string str = "";
                        while ((line = reader.ReadLine()) != null) {
                            str += line + '\n';
                        }
                        parametrs = str.Split('\n');
                        masWithOgr = new string[parametrs.Length - 6];
                        string informText = "";
                        for (int i = 0; i < parametrs.Length - 6; i++) {
                            masWithOgr[i] = parametrs[i + 5];
                        }
                        if (Directory.Exists(parametrs[0])) {
                            path1 = parametrs[0];
                        } else informText += "1,";

                        if (Directory.Exists(parametrs[1])) {
                            path2 = parametrs[1];
                        } else informText += "2,";
                        if (Directory.Exists(parametrs[2])) {
                            path3 = parametrs[2];
                        } else informText += "3,";
                        if (Directory.Exists(parametrs[3])) {
                            path4 = parametrs[3];
                        } else informText += "4,";
                        if (Directory.Exists(parametrs[4])) {
                            path5 = parametrs[4];
                        } else informText += "5,";

                        if (informText != "")
                            MessageBox.Show("Неверные пути: " + informText.TrimEnd(','));
                        else {
                            flag1 = false;
                            thread = new Thread(new ThreadStart(WorkProgram));
                            thread1 = new Thread(new ThreadStart(DeleteFiles));
                            thread1.Start();
                            thread.Start();
                        }
                        
                    }
                }
            }
            Path1.Text = parametrs[0];
            Path2.Text = parametrs[1];
            Path3.Text = parametrs[2];
            Path4.Text = parametrs[3];
            Path5.Text = parametrs[4];
            Expansion.Clear();
            for (int i = 0; i < masWithOgr.Length; i++)
                Expansion.Text += masWithOgr[i] + '\n';
        }

        bool flag2 = false;
        private void DeleteFiles() {
            while (!flag2) {
                FolderPerebor3(path2, path1);
                flag = false;
                FolderPerebor4(path4, path3);

                if (InvokeRequired) {
                    this.Invoke(new Action(() => Actions.SelectionStart = Actions.Text.Length));
                    this.Invoke(new Action(() => Actions.ScrollToCaret()));
                } else {
                    Actions.SelectionStart = Actions.Text.Length;
                    Actions.ScrollToCaret();
                }


                Thread.Sleep(30000);
            }
        }

        bool flag = false; // верхняя папка
        
        public void WorkProgram() {
            while (!flag1) {
                FolderPerebor1(path1, path2);
                flag = false;
                FolderPerebor2(path3, path4);

                if (InvokeRequired) {
                    this.Invoke(new Action(() => Actions.SelectionStart = Actions.Text.Length));
                    this.Invoke(new Action(() => Actions.ScrollToCaret()));
                } else {
                    Actions.SelectionStart = Actions.Text.Length;
                    Actions.ScrollToCaret();
                }


                Thread.Sleep(30000);
            }
            
        }

        void FolderPerebor1(string begin_dir, string end_dir) {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            DirectoryInfo dir1 = new DirectoryInfo(path4);
            DirectoryInfo dir2 = new DirectoryInfo(path5);
            if (flag) {
                //Перебираем все внутренние папки
                foreach (DirectoryInfo dir in dir_inf.GetDirectories()) {
                    //Проверяем - если директории не существует, то создаем;
                    if (dir.Name == dir1.Name || dir.Name == dir2.Name)
                        continue;
                    if (Directory.Exists(end_dir + "\\" + dir.Name) != true) {
                        Directory.CreateDirectory(end_dir + "\\" + dir.Name);
                        if (InvokeRequired)
                            this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " создана в " + end_dir + ": " + '\n')));
                        else
                            Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " создана в " + end_dir + ": " + '\n');
                    } 
                    //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                    FolderPerebor1(dir.FullName, end_dir + "\\" + dir.Name);
                    
                }
                
                //Перебираем файлы в папке источнике.
                FilesPerebor(begin_dir, end_dir);
            } else {
                //Перебираем файлы в папке источнике.
                FilesPerebor(begin_dir, end_dir);
                flag = true;
                FolderPerebor1(begin_dir, end_dir);
            }
        }

        void FilesPerebor(string begin_dir, string end_dir) {
            foreach (string file in Directory.GetFiles(begin_dir)) {
                //Определяем (отделяем) имя файла с расширением - без пути (но с слешем "\").
                string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                bool flagFull = masWithOgr.Length > 0 ? false : true;
                if (File.Exists(end_dir + "\\" + filik) == true && File.GetLastWriteTime(end_dir + "\\" + filik) == File.GetLastWriteTime(file)) {
                    continue;
                } else {
                    if ((!CheckExtension(filik) || flagFull))
                        continue;
                    //Копируем файл с перезаписью из источника в приёмник.
                    File.Copy(file, end_dir + "\\" + filik, true);
                    if (InvokeRequired)
                        this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Файл " + filik.TrimStart('\\') + " скопирован в " + end_dir + ": " + '\n')));
                    else
                        Actions.AppendText(DateTime.Now + ": Файл " + filik.TrimStart('\\') + " скопирован в " + end_dir + ": " + '\n');
                    
                }
            }
            
        }

        bool CheckExtension(string filik) {
            FileInfo info = new FileInfo(filik);
            for (int i = 0; i < masWithOgr.Length; i++) {
                if (info.Extension == masWithOgr[i]) {
                    return false;
                }
            }
            return true;
        }

        void FolderPerebor2(string begin_dir, string end_dir) {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            if (flag) {
                //Перебираем все внутренние папки
                foreach (DirectoryInfo dir in dir_inf.GetDirectories()) {
                    //Проверяем - если директории не существует, то создаем;
                    if (Directory.Exists(end_dir + "\\" + dir.Name) != true) {
                        Directory.CreateDirectory(end_dir + "\\" + dir.Name);
                        if (InvokeRequired)
                            this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " создана в " + end_dir + ": " + '\n')));
                        else
                            Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " создана в " + end_dir + ": " +  '\n');
                    } 
                    //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                    FolderPerebor2(dir.FullName, end_dir + "\\" + dir.Name);
                }

                //Перебираем файлы в папке источнике.
                FilesPerebor(begin_dir, end_dir);
            } else {
                //Перебираем файлы в папке источнике.
                FilesPerebor(begin_dir, end_dir);
                flag = true;
                FolderPerebor2(begin_dir, end_dir);
            }
            
        }
        

        // перебор папок которые надо будет удалить B --- A
        void FolderPerebor3(string begin_dir, string end_dir) {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            DirectoryInfo dir1 = new DirectoryInfo(path4);
            DirectoryInfo dir2 = new DirectoryInfo(path5);
            if (flag) {
                //Перебираем все внутренние папки
                foreach (DirectoryInfo dir in dir_inf.GetDirectories()) {
                    //Проверяем - если директории не существует, то создаем;
                    if (dir.Name == dir1.Name || dir.Name == dir2.Name)
                        continue;
                    if (Directory.Exists(end_dir + "\\" + dir.Name) != true) {
                        Directory.Delete(begin_dir + "\\" + dir.Name);
                        if (InvokeRequired)
                            this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " удалена из " + begin_dir + ": " + '\n')));
                        else
                            Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " удалена из " + begin_dir + ": " + '\n');
                    }
                    //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                    FolderPerebor3(dir.FullName, end_dir + "\\" + dir.Name);

                }

                //Перебираем файлы в папке источнике.
                FilesPerebor2(begin_dir, end_dir);
            } else {
                //Перебираем файлы в папке источнике.
                FilesPerebor2(begin_dir, end_dir);
                flag = true;
                FolderPerebor3(begin_dir, end_dir);
            }
        }


        // перебор файлов для удаления
        void FilesPerebor2(string begin_dir, string end_dir) {
            foreach (string file in Directory.GetFiles(begin_dir)) {
                //Определяем (отделяем) имя файла с расширением - без пути (но с слешем "\").
                string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                bool flagFull = masWithOgr.Length > 0 ? false : true;
                if (File.Exists(end_dir + "\\" + filik) == true && File.GetLastWriteTime(end_dir + "\\" + filik) == File.GetLastWriteTime(file)) {
                    continue;
                } else {
                    if ((!CheckExtension(filik) || flagFull))
                        continue;
                    // Удаляем файл из папки B или каталога в папке B.
                    File.Delete(file);
                    if (InvokeRequired)
                        this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Файл " + filik.TrimStart('\\') + " удалён из " + begin_dir + ": " + '\n')));
                    else
                        Actions.AppendText(DateTime.Now + ": Файл " + filik.TrimStart('\\') + " удалён из " + begin_dir + ": " + '\n');

                }
            }

        }

        // перебор папок которые надо будет удалить D --- C
        void FolderPerebor4(string begin_dir, string end_dir) {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            if (flag) {
                //Перебираем все внутренние папки
                foreach (DirectoryInfo dir in dir_inf.GetDirectories()) {
                    //Проверяем - если директории не существует, то создаем;
                    if (Directory.Exists(end_dir + "\\" + dir.Name) != true) {
                        Directory.Delete(end_dir + "\\" + dir.Name);
                        if (InvokeRequired)
                            this.Invoke(new Action(() => Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " удалена из " + begin_dir + ": " + '\n')));
                        else
                            Actions.AppendText(DateTime.Now + ": Папка " + dir.Name + " удалена из " + begin_dir + ": " + '\n');
                    }
                    //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                    FolderPerebor4(dir.FullName, end_dir + "\\" + dir.Name);
                }

                //Перебираем файлы в папке источнике.
                FilesPerebor2(begin_dir, end_dir);
            } else {
                //Перебираем файлы в папке источнике.
                FilesPerebor2(begin_dir, end_dir);
                flag = true;
                FolderPerebor4(begin_dir, end_dir);
            }

        }




        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (thread != null || thread1 != null) {
                if (thread.IsAlive)
                    thread.Abort();
                if (thread1.IsAlive)
                    thread1.Abort();
            }
        }
    }
}
