@echo "install rimraf"
call npm install rimraf -g

@echo "Delete Node_Modules"
call rimraf node_modules

@echo "Delete typings"
call rimraf typings

@echo "install typings"
call tsd install

@echo "install gulp global scripts"
call npm install -g gulp

@echo "install tsd package manager"
call npm install tsd -g

@echo "compile everything"
call npm install

