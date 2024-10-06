-- このluaスクリプトは、MA_01A110_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_006)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116014)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:どうかされましたか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060002")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {1.0, 0.08, 0.3, 0.5} ,0.5)
keep_ik_lookat(Actor001,Actor002,"J_Head")
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…夢を見るんです<br>バルバロイが世界を飲み込んでいく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:あなたは<br>その夢についてどう思われますか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_060008","MA_01A110_060009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただの夢じゃない、と思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:淘汰の訪れが近いことを<br>継承者に教えてくれているのでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…いったい誰が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060013")

	change_face(Actor002,"Sad")

	--★★マーリン★★:強いてあげるなら…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060014")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:私………だとしたらどうします？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060015")

-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…信じられない話ですが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ほかにもなにか知っているなら<br>教えてほしい、マーリンさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…今はまだ
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ただの夢であってほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060021")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:いつになく弱気ですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マーリン★★:でも、本来であればその反応が正常なのでしょう<br>誰も悪夢に向かって歩いていこうとは思わない
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060023")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マーリンさんは…アーサーは<br>この――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マーリン★★:あなたにすべてを一度に背負わせたくはない<br>アーサー様はそう考えておいでです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…自分が一番背負ってるはずなのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_060028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:だからなおさら、なのでしょうね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060029")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:学生とはひとつずつ学んでいくものです<br>立場を超え、みんなで歩みを進めていく
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060030")


	--★★マーリン★★:ともに学園生活を謳歌し<br>そうして育まれた絆がGSの力となる
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060031")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:級友と学園で過ごせる日々こそが貴重です<br>戦いが激化すればいずれ辛い決断が待っています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:それまではどうか<br>夢も忘れて
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A110_060034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116014)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
