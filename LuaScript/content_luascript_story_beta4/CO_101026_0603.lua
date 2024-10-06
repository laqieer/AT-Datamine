-- このluaスクリプトは、CO_101026_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_008)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディンドラン", "納得")
-- ▲直接出力

	--★★ディンドラン★★:果てなき森の抜け道、ですか…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030002")

-- ▼直接出力
lookWeight = {1.0, 0, 0.4, 0.35}
lookat_delay_weight(Actor002, lookWeight,1)
keep_ik_lookat(Actor002, Actor003, "J_Head")
lookat_delay_weight(Actor001, lookWeight,1.5)
keep_ik_lookat(Actor001, Actor003, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:聞いたことはないかい、義姉さん
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030003")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",2.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディンドラン★★:聞いたことはあります<br>ですが…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030004")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:私もあの森を<br>隅々まで歩いたことがあるわけではなく
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030005")


	--★★ディンドラン★★:そもそも妖精の隠れ里も<br>「あった」と噂されているだけですから
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030006")

-- ▼直接出力
PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力

	--★★ディンドラン★★:そこから繋がるとされる<br>抜け道の場所もわかりません
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030008")

	PlayAction(Actor003,"to  Std_No")

	--★★ディンドラン★★:お力になれずごめんなさい…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_06030011","CO_101026_06030012","CO_101026_06030013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いえ<br>ディンドランさんはなにも悪くないですよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ああ<br>姉さんが謝る必要はなにもない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030016")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:ああっ！パー坊、私のことを心配してくれるのね<br>姉さん、嬉しいわ…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030017")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:だーっ！そんなつもりで言ったんじゃない！<br>あと、学園でパー坊って呼ぶなと言ってるだろ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（学園じゃなければいいのか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_06030019")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ということだけど<br>これからどうする、パーシヴァル？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030021")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ほう？<br>ボクの力を頼らざるを得なくなったようだね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:だが、もう少しキミの能力を見極めたい<br>力を貸すにはまだ時期尚早といえる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030023")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（つまり、なにも浮かんでないわけだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_06030024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディンドランさんでも知らないんじゃ<br>これはもうお手上げだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030026")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:アーサー王には「無理でした」と報告するのかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:キミひとりでするんだね<br>ボクはそんな醜態をさらすつもりはないよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030028")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきディンドランさんは<br>こう言いましたよね？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030030")


	--★★ノワール★★:「私もあの森を<br>隅々まで歩いたことがあるわけではない」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:ええ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030032")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それなら、ディンドランさんが<br>まだ行ったことのない場所を探してみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:なるほど<br>ありかもしれませんね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030034")

-- ▼直接出力
PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:それから<br>ひとつ思い出したのですが
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030035")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:妖精の里には<br>過去のさまざまな記憶が集まると聞きます
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030036")


	--★★ディンドラン★★:里を見つけることができれば<br>抜け道だけでなく
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力

	--★★ディンドラン★★:聖杯についても<br>新たな情報が得られるかもしれません
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:義姉さんが行ったことのない場所を探す、か
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:素晴らしいじゃないかノワール！<br>ボクもこれからそれを提案しようと考えていた
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06030041")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Appl")
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:さすがですわ、パーシヴァル様！
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101026_06030042")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.6)
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:つ、疲れる姉弟だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06030044")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
