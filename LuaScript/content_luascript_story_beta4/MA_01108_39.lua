-- このluaスクリプトは、MA_01108_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-98,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",83,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor003,{-3.82,0,-1.89})
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060013)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:みつけた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390002")

	change_face(Actor002,"Surprise")

	--★★ブルーノ★★:どうしてここにいるとわかった？
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390003")


	--★★ノワール★★:このあたり、小さいころ<br>父さんたちとかくれんぼして遊んだ場所だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:俺が穴場だと思って隠れた場所<br>父さんが俺を見つけてくれた場所だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390005")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★ブルーノ★★:………なつかしいな
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…傷の具合は良いの？<br>父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390007")


	--★★ブルーノ★★:ああ<br>平気だ
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01108_390010","MA_01108_390011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:今までもひとりでこうしていたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390013")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロットとGSをしてからずっと<br>人目を避けて、こうやってずっと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390014")

	change_face(Actor002,"Smile")

	--★★ブルーノ★★:遠目からでもお前たちの成長が見られて<br>戦ってきた甲斐があったと思えたものだ
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:平気なわけないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:キズもそうだけど<br>心だって休まる場所がないじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ブルーノ★★:覚悟のうえだ。すべて<br>親としては失格だとしても
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390020")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアと出会って<br>明かしたくない『本当』があるのを知った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390022")


	--★★ノワール★★:ディナタンと過ごして<br>『本当』を超える虚勢の強さを見た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390024")


	--★★ノワール★★:ランスロットと話をして<br>『本当』と向き合う相手が必要だと知った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:俺たち家族と離れることになってまで<br>父さんが妖精を殺した本当の理由はわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390028")


	--★★ノワール★★:けど、ブライアンに俺たちを託し<br>ランスロットとともに戦い続けて来た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390029")


	--★★ノワール★★:その事実だけは本物だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390030")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:もうどこにもいかないよな。父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブルーノ★★:平気だ、まだ平気だよノワール
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390033")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:まだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390034")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブルーノ★★:私の身体はGSによって因枢分解され<br>戦いに最適化された形態へと変容している
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390036")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ブルーノ★★:キラーズが戦いで受けた傷は容易にふさがる<br>…この五体は因子が擦り切れるまで動き続ける
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPosDuelCommonFormation01_005[1],CharaPosDuelCommonFormation01_005[2],CharaPosDuelCommonFormation01_005[3],0)
slidemove(Actor003,CharaPosDuelCommonFormation01_005[1],CharaPosDuelCommonFormation01_005[2],CharaPosDuelCommonFormation01_005[3],2.3)
wait_time(1.8)
setup_small_camera_start(Camera003)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,CharaPosDuelCommonFormation01_005[4],0.3)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ティルフィング★★:GSを果たしたキラーズは<br>当人の存在自体を消耗し、武器の力へと換えます
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390040")


	--★★ティルフィング★★:ならば…キラーズ本人の存在が<br>消費され切ったとき、どうなるか
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブルーノ★★:ノワールの…最初の武器
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390044")

	change_face(Actor003,"Sad")

	--★★ティルフィング★★:ブルーノ<br>アナタがご子息へそれを告げるのは酷でしょう
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390046")

	PlayAction(Actor003,"to  Std_No")

	--★★ティルフィング★★:己が…武器そのものとなってしまう<br>などと──
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390048")


	--★★ノワール★★:どういう、ことだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ティルフィング★★:武器そのものとなった人間は<br>『存在消失』を起こします
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390051")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ティルフィング★★:『存在消失』──<br>そのキラーズの存在を誰もが忘れ去るのです
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390053")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:………え
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390054")

	change_face(Actor003,"Normal")

	--★★ティルフィング★★:キラーズの力の源泉はバイブスとの絆<br>彼女ら彼らの存在の記憶
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ティルフィング★★:キラーズがバイブスと繋がっているかぎり<br>ある限度まではその消耗を抑えておけますが…
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390056")

	change_face(Actor002,"Sad")

	--★★ブルーノ★★:存在の記憶が使い尽くされたとなれば<br>歴史から私という人間の存在自体が忘却され…
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390057")


	--★★ティルフィング★★:『ジョワイユ』という名の武器<br>──『聖遺物』だけが遺る
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:『ブルーノ』という人間は<br>歴史上、最初からいなかったこととなる
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブルーノ★★:学園でもいずれは学ぶことだ<br>それを覚悟で皆GSに臨んでいるのだ
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390062")


	--★★ティルフィング★★:『存在消失』後、彼を憶えていられるのは<br>バイブスで繋がるマスターと…
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390064")


	--★★ティルフィング★★:継承者だけ…だと言われています<br>ゆえに、この世界にはアナタが必要なのです
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ティルフィング★★:無論、アナタがGSに至った場合<br>そのつがいの運命は、戦いの末──
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390067")


	--★★ノワール★★:皆に、忘れ去られる…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390068")

	change_face(Actor003,"Sad")

	--★★ティルフィング★★:お父様がアナタとの出会いを避けたのは
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:再びアナタに別れのつらさを<br>与えたくなかったがゆえ──
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","MA_01108_390070")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブルーノ★★:だがノワール、約束する<br>もうお前を置いていきはしない
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390071")


	--★★ノワール★★:父、さん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_390073")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブルーノ★★:もう、どこにもいかないよ
	Talk(Actor002,"CHRNAME_BRUNO2","speech","L","MA_01108_390074")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060013)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
