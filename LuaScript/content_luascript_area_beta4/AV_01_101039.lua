-- このluaスクリプトは、AV_01_101039.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",320,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",100,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
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
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor004,Actor002)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:あーっ、ノワールくんだー！<br>やっほー、なにしてるの…
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0001")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
set_common_look_at(Actor002,犬_1)
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:って、犬！？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:フレンか<br>こいつらの世話を頼まれて、ちょっとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0003")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★フレン★★:へえ～、いいなあ！<br>そうだ、私にも手伝わせてー！
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:なにして遊んであげようかなあ<br>わんこだからやっぱり運動かな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0006")

	open_select_window_tag(Actor001,"Normal","AV_01_101039_0007","AV_01_101039_0008","AV_01_101039_0009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ログレスの国境沿いを<br>一周走ってくるっていうのはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0011")

	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ…？<br>それって、かなりの距離じゃない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ダメか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0013")

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:う～ん…時間もかかりすぎるだろうし<br>この子たちもヘトヘトになっちゃうよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★フレン★★:普通に城下町を散歩するくらいで<br>いいんじゃないかな
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それもそうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:水遊びなんてどうだ<br>街の近くに川があっただろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:確かに運動にもなるし楽しそうだけど<br>この子たちって水を怖がったりしない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:水が苦手な犬っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0020")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★フレン★★:いるよ～<br>全部のわんこが泳げるわけじゃないんだから
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0021")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか<br>こいつらは、どうなんだろうな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★フレン★★:じゃあ、確認もかねて<br>少しずつ水に触れさせてみるのはどうかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0023")

	PlayAction(Actor002,"to Finger")
	change_face(Actor002,"Smile")

	--★★フレン★★:桶とかに水を汲んできて<br>ちょっとずつ足もとにかけてみるの
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいな、それ<br>やってみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0025")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:うん！<br>楽しんでくれるといいね
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ボール遊びはどうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:いいね、それ！<br>わんこだけじゃなくて私たちも楽しめそう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:目的はこの子たちの世話だぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0030")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:わかってるってば！<br>でもどうせなら楽しくお世話したいでしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:まあ、たしかに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0032")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:それじゃあさっそく<br>…と思ったけど、もう少し広い場所がいいよね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだな<br>広場のほうまで行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101039_0034")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:オッケー！<br>それじゃ、しゅっぱーつ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","AV_01_101039_0035")

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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
