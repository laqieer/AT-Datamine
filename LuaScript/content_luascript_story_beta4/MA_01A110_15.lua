-- このluaスクリプトは、MA_01A110_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",142,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera005 = SetTemplate("Actor005",-37,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0, 0.5, 0.3,1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:壁、ブチ抜きましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150002")

-- ▼直接出力
lookat_delay_weight_default(Actor001, 0.6)
-- ▲直接出力

	--★★エレイン★★:ギネヴィア様、あの──
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150003")


	--★★ギネヴィア★★:なに？エレイン
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:真似して、いいですかっ
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力

	--★★ギネヴィア★★:真似？なに？別にいいけど…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("エレイン", "気合い")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:壁、ブチ抜きましょうっ！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150007")

	open_select_window_tag(Actor001,"Normal","MA_01A110_150009","MA_01A110_150010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレイン、ギネヴィアっぽいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_150012")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:先輩が言うなら、間違いないですね…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150013")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたし、そんなにいきんでたかなあ…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001,1.0, 0, 0.5, 0.3,1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor003,1.0, 0, 0.5, 0.3,0.8)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.8)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア、採点は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_150016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:満点<br>やる気が感じられてよろしい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150017")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight_default(Actor001, 0.6)
lookat_delay_weight_default(Actor003, 0.6)
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★エレイン★★:～～っ！<br>お、恐れ多い…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150018")

	goto Block1end

::Block1end::
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラヴェイン★★:ノワール君、感謝します
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A110_150020")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:別に、俺はなにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_150021")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "照れ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ラヴェイン★★:私は妹の手を引いていたつもりでした<br>しかしそれは手枷になっていたのかもしれません
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A110_150022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ラヴェイン★★:先に立ち、声を上げてくれる貴方がいて<br>妹は進むことができるように思えます
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A110_150023")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★エレイン★★:お、お兄ちゃん…<br>恥ずかしいよ…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150024")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラヴェイン★★:変わった妹ですが、どうか今後とも
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A110_150025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor001,1.0, 0, 0.5, 0.3,1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:GSもバルバロイもローマも戦いも全部<br>しんどくってキツくってやんなっちゃうよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150027")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:はい…そうですね。本当に
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150029")


	--★★ギネヴィア★★:皆そう思ってる。私もお兄さんも<br>学園の人たち皆「厳しいな～」って思ってる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だからさ、エレイン<br>ひとりじゃないよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150031")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:…はいっ、ギネヴィア様！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_150032")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしたち<br>怖がりながら頑張ろ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor005,"Smile")

	--★★エレイン★★:スタンド・バイ、ユアラウンド…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","N","MA_01A110_150035")

	close_cutin()
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:フォー・ラウンド
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_150037")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
Hide(Actor002)
Hide(Actor005)
Hide(Actor006)
turn_chara(Actor004,-71,0)
setup_small_camera_start(RndCamera003)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:…ダチ想いだよな、ラグネル
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_150039")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:ガウェインほどじゃないよ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_150040")


	--★★ラグネル★★:私はクラスメートとウワサ話をしただけ<br>お互いをさ、知ったほうがいいでしょ？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_150041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…じゃ、そろそろ<br>俺らの問題も片づけようぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_150043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:うん…そうだね
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_150044")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★ガウェイン★★:もうそろそろツラ見せてくんなきゃ<br>信義にもとるってもんだぜ、師匠
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_150045")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
