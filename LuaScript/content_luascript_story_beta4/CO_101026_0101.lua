-- このluaスクリプトは、CO_101026_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",68,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
prop001 = setup_prop_object(10103004)
-- ▲直接出力
-- ▼直接出力
prop001_offset = {0.062, -0.077, -0.02,10.063,22.195,138.648}
-- ▲直接出力
-- ▼直接出力
on_parent(prop001,Actor002, "Loc_weapon_constrint_R", prop001_offset)
-- ▲直接出力
-- ▼直接出力
off_active(prop001)
-- ▲直接出力
-- ▼直接出力
off_parent(prop001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor002, {1.0, 0.08, 0.4, 0.6} , 1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:こんにちは、ディンドランさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力

	--★★ディンドラン★★:ノワールさん、ようこそ大図書院へ<br>今日はどんなご用ですか？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010003")

	open_select_window_tag(Actor001,"Normal","CO_101026_01010005","CO_101026_01010006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:実はちょっと知りたいことがあってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:妖精について詳しく書かれた本を探しているんだ<br>大図書院ならあるかなと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:それなら<br>何冊かあったはずですよ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディンドランさんと話がしたくて来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:そうでしたか<br>はい、なんでもお伺いいたしますよ？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010014")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…さっきのは冗談で<br>実は探している本があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010016")

-- ▼直接出力
PlayPartVoice("ディンドラン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:あら？<br>そうなのですね
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:なにについて調べたいかをお聞かせいただければ<br>書架までご案内しますよ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010018")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:妖精について書かれた本なんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010019")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:今は妖精についてお調べなのですね<br>それも騎士としての任務の一環なのでしょうか
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010021")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、まあ、そういうことになるのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:妖精は<br>人間を聖杯に導いてくれると聞いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:俺たちが聖杯を探すのであれば<br>妖精についても知っておいたほうがいいかなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010024")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010025")

-- ▼直接出力
PlayPartVoice("ディンドラン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディンドラン★★:それに？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、いや、なんでもない<br>気にしないでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01010028")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:はい、承知しました
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010030")

-- ▼直接出力
wait_time(0.5)
lookat_delay_weight_reset(Actor002 , 0.6)
on_active(prop001)
on_parent(prop001,Actor002, "Loc_weapon_constrint_R", prop001_offset)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:妖精について書かれた本でしたら<br>こちらです
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_01010031")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10103004)
prop001_offset = {0.062, -0.077, -0.02,10.063,22.195,138.648}
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
