-- このluaスクリプトは、MA_01A111_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_02","111013_02_h")
Include("content_adv_advsmall_111013_02","Template111013_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_007)
	InitializeTemplateRandomCamera111013_02()
	InitializeTemplate111013_02()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor004, {-2.79, 0, 17.87})
set_pos(Actor005, {3.14, 0, 17.66})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("グリーテン", "肯定2")
-- ▲直接出力

	--★★グリーテン★★:狂おしいほど<br>愛しているかどうかね
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250002")

-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力

	--★★ラシア★★:ローマを狂わせたのはあなたたちでしょう
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250003")


	--★★ラシア★★:兵は生気なく、虚ろな目のまま<br>喜んで殺戮を繰り返して笑っています
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("グリーテン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★グリーテン★★:彼らはワタシたちと狂おしく愛し合えたのね<br>それだけね、笑えてきたね、ふふふ
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250005")


	--★★ラシア★★:皇太子殿下の意向に反するローマ兵が<br>どんどん呑み込まれています
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250007")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリーテン", "喜び")
-- ▲直接出力

	--★★グリーテン★★:違うね、違うね、ラシア<br>ぜんぜん違うよラシアぁ
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250008")

	change_face(Actor002,"Normal")

	--★★グリーテン★★:ワタシたちの浸蝕を受け入れているのは<br>ルーシャス皇太子殿下の夢に賛同する人たちよ
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラシア★★:でまかせを…！
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★グリーテン★★:ルーシャスが<br>ただ悪逆無道な愚者だとお思い？
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250012")


	--★★グリーテン★★:ワタシたちが手を貸してあげてるのは利害の一致<br>けど彼の目指す夢に少なからず敬意を払ってるの
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250013")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData111013_02_06,CameraAssetBundleName111013_02,CameraPos111013_02_106)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★フレン★★:聞かせてよ、それ
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("グリーテン", "落胆")
-- ▲直接出力

	--★★グリーテン★★:ワタシ、オマエに興味ないの<br>ルーシャスくんに媚びながら尋ねたら？
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250016")


	--★★グリーテン★★:いま関心があるのはラシア、オマエなの
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:私はもう惑いませんよ<br>あなたたちに身を委ねはしません
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:ヴェルナルス様に拾われた命…<br>その恩義をお返し出来るまで
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250021")


	--★★グリーテン★★:ローマの理想もルーシャスの夢も<br>オマエにとってはどうでもいいんでしょう？
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250022")

	PlayAction(Actor001,"to  Std_No")

	--★★ラシア★★:到底理解できません
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250023")

-- ▼直接出力
 --PlayPartVoice("グリーテン", "肯定3")
-- ▲直接出力

	--★★グリーテン★★:恩義と<ruby=かりそめ>仮初</ruby>だけを口実に保護者に依存し<br>野心もなく、友人には追い抜かれて
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250024")

	change_face(Actor001,"Anger")

	--★★ラシア★★:うるさい
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250026")


	--★★グリーテン★★:醜くてしょうがないね
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250027")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力

	--★★ラシア★★:うるさい！！
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★グリーテン★★:ねえ
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250029")


	--★★グリーテン★★:ネアは──…誰が殺したの？
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	close_cutin()

	--★★グリーテン★★:泣いて詫びるか、役に立ってみせてね
	Talk(Actor002,"CHRNAME_SISTERS_3","speech","R","MA_01A111_250033")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_weight(Actor003,0.5, 0.08, 0.7, 0.6)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
 lookat_weight(Actor001,0.6, 0.08, 0.7, 0.6)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor002)
Hide(Actor004)
Hide(Actor005)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★フレン★★:…私、ローラとふたりで<br>安心して暮らせる未来が欲しいんだ
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250035")

-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")

-- ▲直接出力

	--★★フレン★★:ずっと一緒にいたいから、だから…<br>ローラは私が守ってあげなきゃって…
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250036")


	--★★フレン★★:ただ、口先だけだったの。私<br>そんな私より先に、あの子は見つけてた
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★フレン★★:君も、決めたの？
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:わかったことがあるの
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250039")


	--★★ラシア★★:望まぬGSは<br>うまく力に反映されぬらしいこと
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250040")


	--★★ラシア★★:逆に、強き者同士が深い絆を培いGSすれば<br>円卓の騎士に匹敵…いえ、圧倒できるはず
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250042")


	--★★フレン★★:絆…
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01A111_250043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:つまりともに生きた時間<br>想いの強さ、覚悟の重み
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250044")


	--★★ラシア★★:ルーシャス様が軽んじる『愛』もまた…<br>絆のひとつ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:…私はもしかしたら<br>幼い頃から──
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力

	--★★ラシア★★:…とっくの昔から<br>決まってたのかもしれない
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_250047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
