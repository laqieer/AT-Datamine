-- このluaスクリプトは、AV_01_101028.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",320,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",100,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
	Actor003 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_002, "Dog_Care_loop", "Normal")
	Actor004 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_003, "Dog_Tailwag_loop", "Normal")
	Actor005 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_001, "Dog_Sleep_loop", "Normal")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor004,Actor002)
PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力

	--★★ガラハッド★★:ノワール？<br>それはお前が飼っている犬か？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ガラハッドか<br>いや、俺の犬じゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:学生寮で飼ってる犬でさ<br>ときどきこうやって世話を見てるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力

	--★★ガラハッド★★:そうなのか<br>…ガラハッドも触ってみてもいいだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:もちろん<br>ガラハッドは犬が好きなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0005")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:嫌いではない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:コルベニック城では<br>姉上がたくさんの動物を飼っているからな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:ノワールのほうこそどうなんだ？<br>世話をするくらいだから嫌いではないと思うが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0008")

	open_select_window_tag(Actor001,"Normal","AV_01_101028_0009","AV_01_101028_0010","AV_01_101028_0011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いうまでもなく大好きさ<br>こいつらの無邪気さにどれだけ癒されたことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0013")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:守ってやらなきゃ<br>人間だけでなく、動物たちも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor001,犬_1)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:作らなきゃ<br>バルバロイに怯えずに済む世界を
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ガラハッドも協力させてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0016")

-- ▼直接出力
set_common_look_at(Actor001,Actor002)
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:この子たちは<br>キラキラした瞳でノワールのことを見ている
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0017")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノワールのことを<br>心から信頼している証だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:みんながキラキラした瞳でいられる<br>そんな世界を作ろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、いっしょに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:犬は好きだけど…<br>動物なら全部好きというわけじゃないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0022")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:む？<br>そうなのか…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:動物じゃないけど<br>虫は比較的…というか全般的に苦手だし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0024")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:虫は…<br>ガラハッドもそれほど得意なわけではないな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0025")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0026")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0027")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっと<br>なんの話をしてたんだっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それはガラハッドが聞きたい…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0029")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:動物は好きなんだけど<br>あまり感情移入はしないようにしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0031")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:感情移入をしないようにしている？<br>それはどういうことだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0032")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:なんというか、その…<br>いなくなったときに辛いからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0033")

-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そういうことか<br>わかる気がする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0034")

-- ▼直接出力
wait_time(1)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:………いなくなったら辛い、か<br>ノワールは優しいのだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0035")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0037")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だったら俺の気持ちがわかると言った<br>ガラハッドも優しいわけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0038")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:えっ？<br>そ、そうだろうか…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AV_01_101028_0039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101028_0040")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_002, "Dog_Care_loop", "Normal")
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_003, "Dog_Tailwag_loop", "Normal")
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_001, "Dog_Sleep_loop", "Normal")
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
