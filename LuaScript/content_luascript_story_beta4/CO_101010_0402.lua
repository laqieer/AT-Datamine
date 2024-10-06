-- このluaスクリプトは、CO_101010_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:騎士たるもの<br>常に周囲の警戒を怠ってはならない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:絶えず人々を守るという意識をもって行動しろ<br>それがログレスの騎士としての心構えの基本だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020003")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:日々研鑽を積み、不測の事態が起きたさいにも<br>適切に対処できるようにしておけ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:それでは、基礎訓練を始める<br>いつもどおりふたり一組で、ノワールお前は――
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020005")

-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ノワール？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ。なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:基礎訓練の時間だ<br>聞いていなかったのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_04020013","CO_101010_04020014")
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

	--★★ノワール★★:聞いてたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020016")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:本当か？<br>その割にぼんやりしていた気がするが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:訓練だからといって気を抜いていると<br>大怪我につながることもある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020019")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:肝に銘じておけ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聞いてませんでした…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:学園内だからと気を抜いているのか？<br>警戒を怠るなと話したばかりだぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…だが、正直に答えたことは褒めておこう<br>騎士として守るべき美徳のひとつだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020024")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020025")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:やれやれ<br>ここが戦場なら命を落としていたぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:戦場で気を抜いたりなんかしない<br>そんなこと、傭兵時代から叩き込まれてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020029")

-- ▼直接出力
setup_small_camera_start(Camera002)
turn_chara(Actor003, 165, 0)
turn_chara(Actor004, 161, 0)
turn_chara(Actor005, 181, 0)
-- ▲直接出力

	--★★ランスロット★★:ここが戦場にならないと言い切れるのか？<br>その油断が命取りになるんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:油断なんかしてないって！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020031")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:その慢心に気を付けろと言っているんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020032")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ノワール★★:あ～～～もう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020034")

-- ▼直接出力
PlayPartVoice("ノワール", "激怒")
-- ▲直接出力

	--★★ノワール★★:そんなこと<br>あんたに言われなくてもわかってるよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020035")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:実戦経験ならずっと積んできたんだ<br>…あんたがいないあいだに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020036")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ど、どうしたんだ…？ふたりとも…
	Talk(Actor003,"NPCNAME_0151","speech","N","CO_101010_04020038")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:ノワールくんも<br>ランスロット先生もなんか怖いよ…
	Talk(Actor005,"NPCNAME_0146","speech","N","CO_101010_04020039")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:他の先生を呼んできたほうがいいかな…？
	Talk(Actor004,"NPCNAME_0153","speech","N","CO_101010_04020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今さらこんな授業受けなくたって<br>俺は十分戦える
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020042")

-- ▼直接出力
 --setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:剣術だって、あんたごときに<br>教えてもらう必要なんかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04020043")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ランスロット★★:なら、試してみるか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04020045")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ4_3")
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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
