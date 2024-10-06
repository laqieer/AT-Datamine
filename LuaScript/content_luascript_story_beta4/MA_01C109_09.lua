-- このluaスクリプトは、MA_01C109_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor003, 0)
turn_lookat(Actor002,Actor003, 0)
turn_lookat(Actor003,Actor001, 0)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ノワールと<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を果たしたことで<br>これまで以上に張り切っているディナタン
	Talk(Actor005,"telop","narration","N","MA_01C109_091001")


	--★★テロップ★★:ペレス王や<ruby=シルバタブラナイツ>銀卓騎士団</ruby>の協力も<br>得られることとなり、すべてが順調に進む
	Talk(Actor005,"telop","narration","N","MA_01C109_091003")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01C109_091004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:そんな中、ノワールとディナタンは<br>アーサーの呼び出しを受けたのだった
	Talk(Actor005,"telop","narration","N","MA_01C109_091005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:どうだ、<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を果たした気分は
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:今までと変わらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090004")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:変わらない、か<br>それもお前らしい
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090005")


	--★★アーサー★★:兄妹でつがいになるとはな<br>他にも選択肢があっただろうに
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090007")


	--★★マーリン★★:………
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C109_090008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺が選んだんだ、俺の武器を<br>俺の武器はディナタンしかいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090009")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-4.279,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
lookWeight = {1.0, 0.08, 0.5, 0.6}
lookat_delay_weight(Actor002, lookWeight,1.0)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor001, lookWeight,1.0)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力

	--★★ディナタン★★:がんばるね、私
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_090011")

-- ▼直接出力
setup_small_camera_start(Camera003)
CloseTalkWindow()
wait_time(0.52)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.5)
lookat_delay_weight_reset(Actor001 , 0.5)
turn_chara(Actor002,-112.832,0)
-- ▲直接出力

	--★★アーサー★★:…そうか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:家族を選んだと思えば<br>お前らしい選択なのかもしれない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:ブライアンや死んだお前の父のことを思えばな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090015")


	--★★ノワール★★:俺らしい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090016")

	open_select_window_tag(Actor001,"Normal","MA_01C109_090017","MA_01C109_090018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺らしいってどの辺が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090020")

-- ▼直接出力
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アーサー★★:ブライアンやディナタン…ともに生きてきた者へのお前の態度を見れば
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090021")

	change_face(Actor003,"Normal")

	--★★アーサー★★:その選択もうなずける、ということさ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…そういうもんか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:家族って、かけがえのないものだからやっぱり特別だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090026")

-- ▼直接出力
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…うん。私もそう思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_090027")

	change_face(Actor003,"Normal")

	--★★アーサー★★:かけがえのないもの、か…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090029")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…大切な家族だった。ブライアンも…覚えてはいないだろうけど、父さんも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ブルーノ・ル・ノワール
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090032")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
wait_time(0.5)
-- ▲直接出力

	--★★ノワール★★:父からもらった名前を背負い妹を武器に選んで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090033")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺は生きるよ<br>家族の絆とともに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:家族、か――…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090035")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★アーサー★★:親から子へ、継承していくというわけかさすがは継承者様だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090037")

	PlayAction(Actor003,"to  Std_Worry")

	--★★アーサー★★:お前が羨ましいよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090038")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力

	--★★ノワール★★:王様だってそう変わらないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090039")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★アーサー★★:どうかなウチはいろいろとややこしくてね
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:少なくともお前のように大切なものを継いだ覚えは無いよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090041")


	--★★ノワール★★:そうか…確かに王家ってのもいろいろ大変だろうしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、でも王位は父親から受け継いだものなんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090043")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:…そうだな確かに、王の名は父から受け継いだものだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090045")


	--★★アーサー★★:だから俺は王としてこれからも進んでいく
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:進んでいかなければならない…この国のために
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090047")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:最近、ずっと考えていることがあってな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090050")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★アーサー★★:王に家族は必要なのだろうか、とどう思う、ディナタン
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090051")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え？わ、私ですか？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_090052")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★アーサー★★:ああ、お前に聞いている！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090053")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:え、えっと……必要とか、そういうのじゃないと思います
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_090054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:だって、家族なんですから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_090055")


	--★★アーサー★★:そうか。そういうものか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090056")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:なら、大事にしないといけないな家族というものを
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090057")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ一緒に戦おう、アーサー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_090058")

-- ▼直接出力
setup_small_camera_start(Camera003)
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★アーサー★★:…俺はこの国のために進んでいくよそれが俺の、果たすべき務めだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C109_090060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
