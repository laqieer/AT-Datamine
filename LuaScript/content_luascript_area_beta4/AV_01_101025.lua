-- このluaスクリプトは、AV_01_101025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Surprise")

	--★★クレア★★:ノワール？<br>武器の修理の依頼…にしてはずいぶん軽装ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0001")


	--★★クレア★★:新しい武器を買いに来たにしては<br>懐が寂しそうだし…？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふ、懐が寂しいは余計なお世話だよ<br>今日はこの店の手伝いをしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアこそどうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:おかみさんの頼まれごとが済んだから<br>それを伝えに来たの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0005")

	open_select_window_tag(Actor001,"Normal","AV_01_101025_0006","AV_01_101025_0007","AV_01_101025_0008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:探偵業だけじゃなくて<br>この店の手伝いもやってるのか。働き者だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:おかみさんには<br>いつもお世話になってるから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0011")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:おかみさんとは仲が良いのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0012")

	change_face(Actor002,"Smile")

	--★★クレア★★:ええ。おかみさんはわたしとヴォールスを<br>家族のように可愛がってくれているわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0013")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ヴォールスを…可愛がる…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★クレア★★:ヴォールスの仕事がうまくいったときは<br>よく頭を撫でているわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0015")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当か！？<br>へえ、見てみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0016")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ここで仕事を手伝っていれば<br>見られる日が来るかもしれないわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにかの事件だったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:いいえ。修理が終わった武器を<br>依頼主のところまで届けてきただけよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…それだけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:それだけ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0022")

	change_face(Actor002,"Normal")

	--★★クレア★★:なにか事件が起こらなければ動かない<br>…というわけではないわ、わたしは
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:お疲れさま<br>大変じゃなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:平気よ。修理を終えた武器をひとつ<br>すぐそこまで届けてきただけだから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そっか、なら良かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0028")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺がここにいるときに<br>同じような頼まれごとをしたなら言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0029")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:代わりに届けてくるからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101025_0030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ありがとう<br>そのときはお願いするわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","AV_01_101025_0031")

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
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
