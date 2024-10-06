-- このluaスクリプトは、MA_01C111_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",107,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera002 = SetTemplate("Actor002",-60,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera003 = SetTemplate("Actor003",125,CharaPos110141_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_007)
	Camera004 = SetTemplate("Actor004",-75,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
DontChangeRandomCamera(true)
set_pos(Actor002,{1.8,0,-0.65})
change_face(Actor002,"Surprise")
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ","挨拶")
-- ▲直接出力

	--★★イゾルデ★★:忙しいのだけれど
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:ディナタンについて聞きたいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200003")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ","否定")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:手を離れた患者のことまで覚えていないわ<br>養護教諭が不在で毎日目が回りそうなの
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:治療したイゾルデに聞くしかないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200005")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ","落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:厳密に言えば違うわね<br>私はただ診ただけ。治療はしていないわ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200006")


	--★★イゾルデ★★:だってあの子の体に<br>治すところなんてなかったもの
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200007")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200008")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力

	--★★イゾルデ★★:健康そのもの。良かったわね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_200010","MA_01C111_200011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:考えすぎか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200013")

-- ▼直接出力
 --PlayPartVoice("イゾルデ","肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:疲れがたまっていたんじゃないかしらって<br>一応は言っておいたけど
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200014")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…また、あのときみたいに<br>倒れたりする可能性は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200015")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera004)
Appear(Actor003)
 --PlayPartVoice("イゾルデ","落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:あるかもしれないわ<br>か弱い乙女を酷使する学園が恨めしいわね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ノワール★★:そんなはずはない…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200018")

	change_face(Actor004,"Normal")

	--★★イゾルデ★★:専門家の意見を疑う？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200019")

	change_face(Actor001,"Anger")

	--★★ノワール★★:小さい頃ころからそばにいるんだ<br>調子が悪そうなことぐらいわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200020")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:それを隠そうとしていることも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200021")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera004)
Appear(Actor003)
 --PlayPartVoice("イゾルデ","落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:…触れて欲しくない<br>デリケートな部分があるとは考えないの？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200022")

	goto Block1end

::Block1end::
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:もういいかしら<br>暇じゃないの、私
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200024")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera003)
 --PlayPartVoice("トリスタン","挨拶")
-- ▲直接出力

	--★★トリスタン★★:イゾルデ、なに何してるの<br>魔女パレード見に行くよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C111_200026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ","肯定2")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★イゾルデ★★:………あー<br>失礼
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200027")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
 --PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まだ聞きたいことが──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200029")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:あとは直接本人にどうぞ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_200030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
Appear(Actor002)
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本人…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200032")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:………にいさん？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200036")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
Hide(Actor004)
Hide(Actor003)
set_rot(Actor001,{0,150,0})
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
setup_small_camera_start(RndCamera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:え、え、えへへへ…<br>あ…あんまり見ないで、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200038")


	--★★ディナタン★★:起きぬけのカオ…はずかしいよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン<br>俺になにか隠しごとをしてないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200041")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…──兄さんこそ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200043")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200044")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力

	--★★ディナタン★★:わすれていること、あるでしょ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200046")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………忘れていること？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200048")

	open_select_window_tag(Actor001,"Normal","MA_01C111_200049","MA_01C111_200050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…教えてほしい、ディナタン<br>俺が…なに何を忘れているっていうんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200052")

-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:………えへへへ<br>やっぱり、そうだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200054")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ごめんね兄さん<br>私、なんか甘えてる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なに何も忘れてなんかいないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200057")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…どう言ったらいいかわからないけど<br>ごめんなさい、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200058")

-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:なかったことにも、できなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200060")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:おぼえているなら
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200062")

-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:もし本当に<br>憶えてくれているなら──
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200063")

-- ▼直接出力
CameraEX = set_camera({3.28,1.2,2.87,-5,150,0,25})
set_camera_nearclip(CameraEX,0.5)
setup_small_camera_start(CameraEX)
on_active(FX_DoF)
slidemove(CameraEX,{3.3,1.2,2.835},5.0)
-- ▲直接出力

	--★★ディナタン★★:ねえ──兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200065")

	open_select_window_tag(Actor001,"Normal","MA_01C111_200067","MA_01C111_200068")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera001)
off_active(FX_DoF)
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なにか調子を崩すようなことがあったのか？<br>席を外すよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200070")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…──うん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200071")

-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ありがとう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200072")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
off_active(FX_DoF)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そばにいさせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200074")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そばにいてくれるだけじゃ、やだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200075")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_200076")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:………あの、ね？<br>すぐ、良くなるから──
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200077")

	goto Block3end

::Block3end::
-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C111_20_Bell")
wait_time(8)
setup_small_camera_start(RndCamera001)
wait_time(1)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:………ひとりにしてほしくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200079")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ねむりたくなっちゃった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_200081")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
