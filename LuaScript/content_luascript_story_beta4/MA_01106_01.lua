-- このluaスクリプトは、MA_01106_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_01","111091_01_h")
Include("content_adv_advsmall_111091_01","Template111091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera111091_01()
	InitializeTemplate111091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor002 = InitializeCharacter_2DOnly("101012","004","101012004")
	Actor003 = InitializeCharacter_2DOnly("101050","001","101050001")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:７年前
	Talk(Actor004,"telop","narration","L","MA_01106_010003")


	--★★ノワール★★:…『武器』ってなに、ブライアン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010004")


	--★★ブライアン★★:…ブッ殺すことが出来る道具、じゃあねえの
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010005")


	--★★ノワール★★:母さん、さいごに言ったんだ<br>「貴方の武器を見つけて」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010006")


	--★★ノワール★★:ブライアンのところになら<br>いっぱいあるんだよね、武器
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010007")


	--★★ブライアン★★:…おめえが使えるモンなんざねえよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010008")


	--★★ノワール★★:オレを傭兵団に入れてほしいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010009")

	change_face(Actor003,"Surprise")

	--★★ブライアン★★:はァ？おめえら兄妹の衣食住だけじゃなく<br>命まで預かんなきゃなんねえなんざ御免だね
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:最初は掃除係や食事係でもいいよ<br>傭兵団で鍛えてもらって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:武器の扱いが一人前になって<br>そんで、このコートが似合うくらいになったらさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010012")


	--★★ノワール★★:父さんを探しに行くんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010013")

	change_face(Actor003,"Sad")

	--★★ブライアン★★:…おめえらの親父──ブルーノの姿は<br>一般には知らされてねえ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010014")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよ急に。知ってるよ…！<br>誰が妖精を守ってたか、秘密だったってことだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010015")


	--★★ブライアン★★:だがログレスの──<br>円卓の騎士の上のヤツらは知ってるはずだ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010016")


	--★★ブライアン★★:おめえが金コート着てちょろちょろ戦場出りゃ<br>妖精殺しと繋がってるヤツとしてすぐ捕まる
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…だからさ、目立つだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010018")

	change_face(Actor003,"Surprise")

	--★★ブライアン★★:あ？
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010019")


	--★★ノワール★★:母さんはこのコートを縫いながら言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010020")


	--★★ノワール★★:「父さんは誉れ高き円卓の騎士なの<br>いつでも私たちを見守ってくれている」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010021")

	change_face(Actor001,"Smile")

	--★★ノワール★★:それ、俺が証明してみせるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010022")

	change_face(Actor003,"Normal")

	--★★ブライアン★★:…お前が目立てば<br>親父さんのほうから来てくれるってか
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010023")


	--★★ノワール★★:もしくは円卓の騎士が迎えに来てくれるかもね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010024")

	change_face(Actor003,"Smile")

	--★★ブライアン★★:………小せえな
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010026")

	change_face(Actor003,"Normal")

	--★★ブライアン★★:まだ小せえっつってんだよ<br>憧れてんなら喚き散らせ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010027")


	--★★ブライアン★★:「俺はここだ！」ってよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010028")


	--★★ノワール★★:…！どういう、こと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010029")


	--★★ブライアン★★:やるなら徹底的にだ<br>嫌がらせかってぐらい派手に目立ってやれ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010030")

	change_face(Actor003,"Smile")

	--★★ブライアン★★:おめえが一人前になったら<br>俺の傭兵団を預けてやる
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010031")


	--★★ブライアン★★:今はメンドくせえから『名もなき傭兵団』だが<br>おめえが団長になったアカツキには──
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010032")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01106_01_Footstep")
-- ▲直接出力
	open_cutin(1,3)
	on_cutin(1,Actor002,"Normal")
-- ▼直接出力

wait_time(1.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ブライアン★★:………おかえり
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010034")


	--★★ブライアン★★:母ちゃんに<br>おやすみ言えたか？
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_010035")

	close_cutin()

	--★★ディナタン★★:うん<br>でも不思議なの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_010036")


	--★★ノワール★★:不思議？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_010037")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:お母さんの好きなお花を<br>お供えしようとしたら、もうひとつあったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_010038")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Surprise")
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:同じお花があったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_010040")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101012","004","101012004")
	InitializeCharacter_2DOnly_Preload("101050","001","101050001")
	system.PreLoadRequest(CameraAssetBundleName111091_01)
end
