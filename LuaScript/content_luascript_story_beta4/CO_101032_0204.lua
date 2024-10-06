-- このluaスクリプトは、CO_101032_0204.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101032","001","101032001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:よ、よう！ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェイン？どうしたんだ、こんなところで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:えーっと、あのさ…ガレスのヤツ、怒ってなかったか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040004")


	--★★ガウェイン★★:こないだ、ハラいっぱいになったせいか言わなくてもいいこと言っちまったからよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_02040007","CO_101032_02040008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:すごく怒ってたぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040010")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ああーっ、やっぱりかぁ！？なんであんなこと言っちまったかなあ、俺
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:親しき仲にも礼儀あり、ってやつだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040012")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:わかっちゃいるんだけどよおはあ、自己嫌悪
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:怒ってはいなかったかなむしろ、燃え上がってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040015")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:燃え上がってた？どーゆーことだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前に美味いと言わせる料理を作るんだってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:へえ…楽しみだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040018")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんにしてもどこかで一度謝ったほうがいいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040020")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そうだな…うん、そうするよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:話聞いてくれてサンキュあとよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040022")


	--★★ノワール★★:うん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ガレスのこと、よろしく頼むな円卓の騎士のひとりとはいえ、女の子だしさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040024")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:素直じゃないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02040025")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:うっせ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_02040027")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor003, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor003, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101032","001","101032001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
