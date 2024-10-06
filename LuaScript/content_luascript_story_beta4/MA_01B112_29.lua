-- このluaスクリプトは、MA_01B112_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114041_01","114041_01_h")
Include("content_adv_advsmall_114041_01","Template114041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114041_01()
	InitializeTemplate114041_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114041)
	Actor001 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor002 = InitializeCharacter_2DOnly("101010","002","101010002")
	Actor003 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor004 = InitializeCharacter_2DOnly("101036","002","101036002")
	Actor005 = InitializeCharacter_2DOnly("101056","002","101056002")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor003,"Sad")

	--★★アーサー★★:…「きっかけは<br>錆びついた剣の軋み」
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_290002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！まさか………！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_290004")


	--★★アーサー★★:そうだ、ノワール
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_290005")


	--★★ノワール★★:剣の祭壇とそこにあった<ruby=ティルフィング>剣</ruby>が…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_290006")


	--★★ペレス★★:太古になされた聖域化の名残<br>過去の継承者のキラーズ…その聖遺物
	Talk(Actor005,"CHRNAME_PEREZ","speech","R","MA_01B112_290008")


	--★★ペレス★★:封たる劔に人間としての存在は不純物…<br>それを廃した聖遺物のみが聖域化が行える
	Talk(Actor005,"CHRNAME_PEREZ","speech","R","MA_01B112_290010")


	--★★ランスロット★★:つまり、バルバロイの殲滅…<br>世界救済を成すのなら──
	Talk(Actor002,"CHRNAME_LANCELOT2","speech","L","MA_01B112_290012")


	--★★ランスロット★★:継承者のキラーズは聖遺物として<br>この地に突き立ち、封とならねばならない
	Talk(Actor002,"CHRNAME_LANCELOT2","speech","L","MA_01B112_290013")


	--★★ペレス★★:ランスロット卿はその後、長きに渡って<br>この地で封としての孤独を味わうことになる
	Talk(Actor005,"CHRNAME_PEREZ","speech","R","MA_01B112_290015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114041)
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_2DOnly_Preload("101010","002","101010002")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	InitializeCharacter_2DOnly_Preload("101036","002","101036002")
	InitializeCharacter_2DOnly_Preload("101056","002","101056002")
	system.PreLoadRequest(CameraAssetBundleName114041_01)
end
