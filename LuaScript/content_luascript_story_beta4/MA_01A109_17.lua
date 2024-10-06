-- このluaスクリプトは、MA_01A109_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",95,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera002 = SetTemplate("Actor002",-91,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
load_image("101030460", "content_still_10103046_image", "101030460_StillImage")
tegami2 = setup_prop_object(10106003)
 --CUT_1 = set_camera({-17.80617,2.11519,9.324,16.00367,64.65781,0,24})
-- ▲直接出力
-- ▼直接出力
off_active(tegami2)
-- ▲直接出力
-- ▼直接出力
tegami_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Bow")
	change_face(Actor002,"Sad")

	--★★エレイン★★:おはようございます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170002")

	open_select_window_tag(Actor001,"Normal","MA_01A109_170004","MA_01A109_170005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園が嫌いなんじゃなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…不登校で<br>兄に迷惑をかけるわけにもいきません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170008")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★エレイン★★:この学園のぜんぶが<br>嫌いなわけでもありませんし…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:花畑以来だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:覚えていてくださって<br>嬉しいです…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170013")

	change_face(Actor002,"Shy")

	--★★エレイン★★:その節は…失礼しました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170014")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
SwitchMob(false)
--フェードイン
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かを待っているの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170016")

	change_face(Actor002,"Sad")

	--★★エレイン★★:…あなたは私を<br>悪くは言わないのですか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170019")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:私は…<dot>ローマへと逃げ</dot><br><dot>ローマから逃げて来た</dot>女です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:敵へ花を<br>手向ける女です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170022")

	open_select_window_tag(Actor001,"Normal","MA_01A109_170024","MA_01A109_170025")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:気持ちがわかるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170027")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…え？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170028")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺が花を手向ける相手の中にも<br>ログレスの敵がいる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170029")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:敵へ花を<br>手向ける男だ。俺も
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170031")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマへ逃げた？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170033")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:学園を離れたかっただけで<br>…別にローマに興味があったわけではありません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170035")

	change_face(Actor002,"Sad")

	--★★エレイン★★:ですが結局<br>戻ってきてしまいました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170036")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★エレイン★★:どこにいればいいのか<br>わからなくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170037")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:敵でも、誰でも悼む気持ちは一緒だ<br>誰かがなにかを<ruby=うしな>喪</ruby>うのはいつだってイヤだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170039")


	--★★ノワール★★:そもそも俺も以前は<br>ログレスの敵だったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…聞き及んでいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:継承者──ノワール様
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170043")


	--★★エレイン★★:ログレスが長年探し続けて来た継承者<br>バルバロイという侵略者から歴史を救う者
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170045")


	--★★エレイン★★:先の戦いでの継承者様の覚醒は<br>戦場にいた者が全員が目の当たりにした奇跡
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:すでに学園中の周知の事実です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:円卓の騎士でありながら<br>以前は元カレドニアの傭兵…<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を果たし──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:<dot>父</dot>から、<dot>名</dot>を託されたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:すべては<br>いなくなってしまった人のおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170052")


	--★★ノワール★★:俺は『<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>』<br><dot>ブルーノ</dot>・ル・ノワール
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170053")


	--★★ノワール★★:二度と家族を喪わないために<br>家族を守り続けるために
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170055")


	--★★ノワール★★:同じ思いを誰にもさせないために
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:<ruby=ギネヴィア>同じ意志を持った人</ruby>に手を引かれ<br>その手を握り返した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だから、俺もああして花を──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170059")


	--★★エレイン★★:………あなた、は
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170062")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:あなたは、変われたんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170063")

	change_face(Actor001,"Normal")

	--★★ノワール★★:変わる…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170064")

-- ▼直接出力
CloseTalkWindow() 
setup_small_camera_start(Camera002)
wait_time(0.3)
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor002,"to LookFor")
wait_time(1.5)
PlayActionDirect(Actor002,"to Show")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
show_image("101030460", 0.0, 0.0, 0,true,false)
fadein(1.5)
wait_time(1.5)
 --[[
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
 --]]
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:…はじめまして<br>エレインといいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170066")

-- ▼直接出力
CloseTalkWindow() 
hide_image(0)
 --手紙を読む
PlayActionDirect(Actor001,"to ReadLetter")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
wait_time(0.8)
-- ▲直接出力

	--★★ノワール★★:「いきなり不躾ですが」…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン★★:…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_170070")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:「先輩<br>と呼んでもいいですか」──…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_170071")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030460", "content_still_10103046_image", "101030460_StillImage")
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
