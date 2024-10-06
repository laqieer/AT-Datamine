-- このluaスクリプトは、MA_01B109_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_006)
	Camera002 = SetTemplate("Actor002",71.4,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera003 = SetTemplate("Actor003",53.2,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力

	--★★パーシヴァル★★:ボクは知らないな<br>『聖杯城の巫女』なんて
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190002")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★フィエナ★★:ほ、本当だよ！<br>本当に私──…！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_190004")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ガラハッド★★:姉上が嘘つきだとでも言う気か！
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_190005")

	open_select_window_tag(Actor001,"Normal","MA_01B109_190006","MA_01B109_190007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだ？喧嘩か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_190009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:違う！<br>ボクはまっとうな主張をしているだけだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190010")

	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:喧嘩などと<br>低俗な表現をしてほしくないね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:女の子をいじめるなよ、パーシヴァル
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_190013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:誰がいじめっ子だ、失礼な！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190014")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:傍から見ていると<br>少しそう見えなくもないです。パーシヴァル様
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190015")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:なんだって！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190016")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:ちょうどいいところに<br>ノワール様
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190018")

-- ▼直接出力
CloseTalkWindow()
OpenFirstAppearance(Actor003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:パー坊…パーシヴァル様を<br>説得するのを手伝ってもらえませんか
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190019")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ボクは責務ある者として<br>まっとうなことを言っているだけだ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★パーシヴァル★★:相手は、ボクたち円卓が信用ならないといって<br>新たに作られた銀卓騎士団だぞ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:そういう確執がある相手に対して<br>呑気でいるわけにはいかないだろう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190023")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:姉上はともかく<br>継承者、問題はキミだ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190024")


	--★★パーシヴァル★★:キミは、フィエナが幼馴染というだけで<br>無警戒すぎるんじゃないか？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力

	--★★ディンドラン★★:彼女たちは聖杯を見つけるという<br>共通した目的を持つ仲間です
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:「聖杯まで案内」なんて<br>本当にできるかも疑わしいね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★パーシヴァル★★:ボクらの故郷の城の図書館の蔵書にだって<br>そんなことを書いたものはなかった！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190028")

	PlayAction(Actor002,"to  Std_Worry")

	--★★パーシヴァル★★:聖杯に関するものであればココよりも<br>はるかに多く揃えたあの図書館でも、だ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B109_190029")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_190031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディンドラン★★:それは…ええ、そうですね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190032")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:私たちの故郷は…少し特殊で<br>聖杯に関する資料が数多くありました
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190033")


	--★★ディンドラン★★:ですが聖杯の場所がわかる力など<br>本物の妖精でもない限り──
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B109_190034")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力

	--★★ガラハッド★★:姉上ができると言ったらできる！<br>姉上は嘘なんか吐かない！
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_190036")

	open_cutin(3,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
	on_cutin(3,Actor003,"Surprise")
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	close_cutin()
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:そちらがガラハッドたちを<br>信用できないと言うのも理解はできる
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_190038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ガラハッド★★:だが誓って姉上は嘘を言わない<br>そんなことするわけない
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_190039")

-- ▼直接出力
wait_time(1.0)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-50,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガラハッド★★:そうでしょう？姉上
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_190041")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-210,0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★フィエナ★★:う…うん<br>…できる。できるよ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_190042")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★フィエナ★★:それが、私の役目だからね
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B109_190044")

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
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
