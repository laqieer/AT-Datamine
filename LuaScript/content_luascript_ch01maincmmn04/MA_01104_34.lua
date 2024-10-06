-- このluaスクリプトは、MA_01104_34.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
off_active(Actor004) -- アーサー非表示
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ディナタン★★:どうしてヒドイコトばっかり言うの？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340002")


	--★★マルディサント★★:誰のハナシだよ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:最初、大図書院ではよくしてくれたのに<br>ここでは…ずぅっと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:フェアリーの羽音が<br>耳障りなだけ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340006")


	--★★マルディサント★★:逆にアンタこそさ<br>なんでイイコトばっかしてんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340008")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:そう見えるの？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340009")


	--★★マルディサント★★:良く見られたくて<br>しょーがねえってツラだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:やれることを探しているだけだよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340011")


	--★★マルディサント★★:見上げたコンジョー
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:そして見つけたの<br>マルディサント、あなたを
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:アタシがなんだって？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340016")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ディナタン★★:私を<br>剣の祭壇の儀式に連れて行って
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:ゲホゲホッ！？ウエッ！？<br>ハァッ…！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340018")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:アンタは人質なんだろ？<br>オニーサンを学園にたてつかせないための
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:まだ儀式の日取りも決まってねえのに<br>学園抜け出していいと思ってんのか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:授業もろくに出ていない貴方なら<br>いなくなっても怪しまれないでしょ？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340022")


	--★★マルディサント★★:…だから<br>非行少女を盾に使おうって？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:私は祭壇で力を得る<br>そうすれば学園も私たち兄妹を手放せなくなる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340026")


	--★★マルディサント★★:アンタに戦う素養なんざねえよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340027")


	--★★ディナタン★★:そのときはそのときで考えます
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340028")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:乗ると思うのか？<br>このアタシが
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ぜひ<br>図書院俳優？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340030")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to Sit01_BA01")
	change_face(Actor002,"Shy")

	--★★マルディサント★★:ウッ！きたねえぞ！！<br>それヒミツっつったろォッ！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryData110141_02_04,CameraAssetBundleName110141_02,CameraPos110141_02_104)
turn(Actor001,0,207,0,0.2)
-- ▲直接出力

	--★★モルガン★★:せめてお兄さんに相談したら？<br>一緒についていってもらえないかって
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…それは駄目です。兄さんは兄さんで頑張ってる<br>兄さんに、余計な心配をかけたくないんです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340034")


	--★★モルガン★★:療養院のフェアリーのままでは不満？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340035")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:兄の義務のままでいたくないんです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340037")


	--★★モルガン★★:義務？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:兄が帰ってこなければならない理由…<br>それだけの立場でいたくない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340040")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ディナタン★★:待っているだけは、イヤです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340041")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Smile")

	--★★モルガン★★:がむしゃらで青くて盲目ぅ～
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:ランス兄ちゃんには命を助けてもらった借りが<br>この学園には一宿一飯以上の恩義があります
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:モルガン先生には<br>厚意で働かせてもらっています
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340045")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ディナタン★★:学園においてもらっているからには<br>ずっとゲスト扱いでは居心地が悪い…ですから！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340046")


	--★★モルガン★★:真面目、そして義理堅い…！
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:とはいえ無断で出ていきゃ懲罰もんだぜ…<br>ギネヴィア王妃殿下じゃねえんだから
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340048")


	--★★モルガン★★:そう言うかと思って～<br>こういう話になるんじゃないかと思って～
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340049")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor004) -- アーサー表示
DontChangeRandomCamera(true)
on_camera(Camera004)
change_face(Actor004,"Smile")
PlayActionDirect(Actor004,"to Greet_one")
wait_time(1.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★モルガン★★:お姉さん<br>こちらに王様を用意しました～
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340051")

	change_face(Actor002,"Surprise")

	--★★マルディサント★★:うわあ王様だ！？！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340052")

	change_face(Actor004,"Smile")

	--★★アーサー★★:儀式、いいんじゃない？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_340053")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:X日後にでも行っといで？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_340054")


	--★★マルディサント★★:うわあ適当だ！？！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340055")

-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:今ならノワールやギネヴィアたちによって<br>剣の祭壇までの道は拓かれている
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_340056")

	PlayAction(Actor004,"to  Std_Talk")

	--★★アーサー★★:むしろ今が最も安全といえば安全だ<br>勝手に出て行かれるよりはよっぽどいいさ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_340057")

	change_face(Actor003,"Normal")

	--★★モルガン★★:マルディサントは儀式を済ませてるものね？<br>道案内、お願いね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…外、出ても平気かな。アタシ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340059")


	--★★モルガン★★:最近のお加減は？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340061")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:おっきな声がめっちゃ出る
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340062")

	change_face(Actor003,"Smile")

	--★★モルガン★★:なら良ぉーし。いってらっしゃい！<br>それでいいのよね、アーサー？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_340063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:X日後、X日後だぞ。いいな？<br>ちゃんと連れて行くんだぞ？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01104_340064")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:あ、あ、ありがとうございます…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_340065")

	PlayAction(Actor002,"to Sit01_BA01")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:ほれみろ…<br>安息が乱され始めたぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_340067")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
